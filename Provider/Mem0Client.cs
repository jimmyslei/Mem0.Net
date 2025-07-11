using Mem0.Net.Models;
using Mem0.Net.Options;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mem0.Net;

public class Mem0Client : IMem0Client
{
    private readonly Mem0Options _options;
    private readonly HttpClient _httpClient;
    private readonly static string _baseurl = "https://api.mem0.ai";
    private readonly JsonSerializerOptions _jsonOptions;

    public Mem0Client(IOptions<Mem0Options> options)
    {
        _options = options.Value;
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(_baseurl)
        };
        _httpClient.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Token", _options.ApiKey);
        _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }


    /// <summary>
    /// Add memories to the Mem0 service
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Response with created memory IDs</returns>
    public async Task<AddAddMemoriesResponse?> AddMemoriesAsync(AddMemoriesRequest request)
    {
        var requestContent = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(
            $"/v1/memories",
            requestContent);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<AddAddMemoriesResponse>(_jsonOptions);
        }
        else
        {
            var errorMessage = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"Failed to add memories: {response.StatusCode}, {errorMessage}");
        }

    }

    /// <summary>
    /// Search for memories based on a query
    /// </summary>
    /// <param name="query">The search query</param>
    /// <param name="indexName">Name of the index to search</param>
    /// <param name="limit">Maximum number of results to return</param>
    /// <param name="minRelevanceScore">Minimum relevance score for results</param>
    /// <param name="filters">Optional metadata filters</param>
    /// <returns>Search results</returns>
    public async Task<List<SearchMemoriesResponse>?> SearchAsync(
        string query,
        string indexName = "default",
        int limit = 10,
        float minRelevanceScore = 0.7f,
        Dictionary<string, object> filters = null)
    {
        var request = new SearchMemoriesRequest
        {
            Query = query,
            Limit = limit,
            Filters = filters
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"/v2/memories/search",
            request,
            _jsonOptions);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<SearchMemoriesResponse>>(_jsonOptions);
        }
        else
        {
            var errorMessage = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"Failed to search memories: {response.StatusCode}, {errorMessage}");
        }
    }

    /// <summary>
    /// Get a memory by ID
    /// </summary>
    /// <param name="memoryId">ID of the memory to retrieve</param>
    /// <returns>Memory details</returns>
    public async Task<MemoryInfoResponse?> GetMemoryAsync(string memoryId)
    {
        var response = await _httpClient.GetAsync($"/v1/memories/{memoryId}");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<MemoryInfoResponse>(_jsonOptions);
        }
        else
        {
            var errorMessage = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"Failed to get memory: {response.StatusCode}, {errorMessage}");
        }
    }

    /// <summary>
    /// Delete a memory by ID
    /// </summary>
    /// <param name="memoryId">ID of the memory to delete</param>
    /// <returns>True if deletion was successful</returns>
    public async Task<bool> DeleteMemoryAsync(string memoryId)
    {
        var response = await _httpClient.DeleteAsync($"/v1/memories/{memoryId}");

        if (response.IsSuccessStatusCode)
        {
            return true;
        }
        else
        {
            var errorMessage = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"Failed to delete memory: {response.StatusCode}, {errorMessage}");
        }
    }

}

