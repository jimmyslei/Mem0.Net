using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.NetCore.Models;

public class MemoryHistoryResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("memory_id")]
    public long MemoryId { get; set; }
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }
    [JsonPropertyName("input")]
    public List<MessageContent> Input { get; set; }
    [JsonPropertyName("new_memory")]
    public string NewMemory { get; set; }
    [JsonPropertyName("old_memory")]
    public long OldMemory { get; set; }
    [JsonPropertyName("event")]
    public long Event { get; set; }
    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

}
