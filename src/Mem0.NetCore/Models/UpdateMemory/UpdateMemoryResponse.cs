using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.NetCore.Models;

public class UpdateMemoryResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("text")]
    public string Text { get; set; }
    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }
    [JsonPropertyName("agent_id")]
    public string AgentId { get; set; }
    [JsonPropertyName("app_id")]
    public string AppId { get; set; }
    [JsonPropertyName("run_id")]
    public string RunId { get; set; }
    [JsonPropertyName("hash")]
    public string Hash { get; set; }
}
