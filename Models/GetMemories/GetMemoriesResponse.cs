using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.Net.Models;

public class GetMemoriesResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("owner")]
    public string Owner { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [JsonPropertyName("organization")]
    public string Organization { get; set; }
    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; set; }
    [JsonPropertyName("expiration_date")]
    public string ExpirationDate { get; set; }

}
