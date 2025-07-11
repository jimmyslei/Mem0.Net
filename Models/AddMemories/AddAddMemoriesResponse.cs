using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.Net.Models;

/// <summary>
/// Response model for adding memories
/// </summary>
public class AddAddMemoriesResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("data")]
    public AddResponseData Data { get; set; }
    [JsonPropertyName("event")]
    public string Event { get; set; }
}

public class AddResponseData
{
    [JsonPropertyName("memory")]
    public string memory { get; set; }
}

