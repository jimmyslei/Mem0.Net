﻿using Mem0.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mem0.NetCore;

public interface IMem0Client
{
    /// <summary>
    /// Add memories to the Mem0 service
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Response with created memory IDs</returns>
    Task<AddMemoriesResponse?> AddMemoriesAsync(AddMemoriesRequest request);

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
    Task<MemoryInfoResponse?> GetMemoryByIdAsync(string memoryId);

    /// <summary>
    /// Delete a memory by ID
    /// </summary>
    /// <param name="memoryId">ID of the memory to delete</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteMemoryAsync(string memoryId);

    /// <summary>
    /// Get memories based on various criteria
    /// </summary>
    /// <param name="request">filter params </param>
    /// <returns></returns>
    /// <exception cref="HttpRequestException"></exception>
    Task<GetMemoriesResponse?> GetMemories(GetMemoriesRequest request);

    /// <summary>
    /// get memory history by memory ID
    /// </summary>
    /// <param name="memoryId"></param>
    /// <returns></returns>
    /// <exception cref="HttpRequestException"></exception>
    Task<List<MemoryHistoryResponse>?> GetMemoryHistory(string memoryId);

    /// <summary>
    /// Update an existing memory
    /// </summary>
    /// <param name="memoryId"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="HttpRequestException"></exception>
    Task<UpdateMemoryResponse?> UpdateMemory(string memoryId, UpdateMemoryRequest request);

    /// <summary>
    /// batch update memories in Mem0
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="HttpRequestException"></exception>
    Task<string> BatchUpdateMemories(BatchUpdateMemoriesRequest request);

    /// <summary>
    /// batch delete memories in Mem0
    /// </summary>
    /// <param name="memoryIds"></param>
    /// <returns></returns>
    /// <exception cref="HttpRequestException"></exception>
    Task<string> BatchDeleteMemories(string[] memoryIds);

    /// <summary>
    /// delete memories based on criteria
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="HttpRequestException"></exception>
    Task<string> DeleteMemories(DeleteMemoriesRequest request);

    /// <summary>
    /// Submit feedback to the Mem0 service
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="HttpRequestException"></exception>
    Task<FeedbackResponse?> Feedback(FeedbackRequest request);

}

