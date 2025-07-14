using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.NetCore.Models;

public class SearchMemoriesResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("memory")]
    public string Memory { get; set; }
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    [JsonPropertyName("categories")]
    public List<string> Categories { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; set; }
}
