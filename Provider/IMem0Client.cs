using Mem0.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mem0.Net;

public interface IMem0Client
{
    /// <summary>
    /// Add memories to the Mem0 service
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Response with created memory IDs</returns>
    Task<AddAddMemoriesResponse?> AddMemoriesAsync(AddMemoriesRequest request);

    /// <summary>
    /// Search for memories based on a query
    /// </summary>
    /// <param name="query">The search query</param>
    /// <param name="indexName">Name of the index to search</param>
    /// <param name="limit">Maximum number of results to return</param>
    /// <param name="minRelevanceScore">Minimum relevance score for results</param>
    /// <param name="filters">Optional metadata filters</param>
    /// <returns>Search results</returns>
    Task<List<SearchMemoriesResponse>?> SearchAsync(
        string query,
        string indexName = "default",
        int limit = 10,
        float minRelevanceScore = 0.7f,
        Dictionary<string, object> filters = null);

    /// <summary>
    /// Get a memory by ID
    /// </summary>
    /// <param name="memoryId">ID of the memory to retrieve</param>
    /// <returns>Memory details</returns>
    Task<MemoryInfoResponse?> GetMemoryAsync(string memoryId);

    /// <summary>
    /// Delete a memory by ID
    /// </summary>
    /// <param name="memoryId">ID of the memory to delete</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteMemoryAsync(string memoryId);

}

