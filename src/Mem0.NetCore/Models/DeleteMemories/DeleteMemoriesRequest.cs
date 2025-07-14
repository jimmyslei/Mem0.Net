using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.NetCore.Models;

public class DeleteMemoriesRequest
{
    [JsonPropertyName("user_id")]
    public long UserId { get; set; }
    [JsonPropertyName("agent_id")]
    public string AgentId { get; set; }
    [JsonPropertyName("app_id")]
    public string AppId { get; set; }
    [JsonPropertyName("org_id")]
    public string OrgId { get; set; }
    [JsonPropertyName("project_id")]
    public string ProjectId { get; set; }
    [JsonPropertyName("run_id")]
    public string RunId { get; set; }
    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
}
