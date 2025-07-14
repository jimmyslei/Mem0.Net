using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.NetCore.Models;

/// <summary>
/// Request model for adding memories
/// </summary>
/// <remarks>This class is used to encapsulate the data required for adding messages, including user and agent
/// identifiers, application and organizational context, and additional metadata. It is typically serialized to JSON for
/// API communication.</remarks>
public class AddMemoriesRequest
{
    [JsonPropertyName("messages")]
    public List<MessageContent> Messages { get; set; }
    [JsonPropertyName("agent_id")]
    public string AgentId { get; set; }
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }
    [JsonPropertyName("app_id")]
    public string AppId { get; set; }
    [JsonPropertyName("org_id")]
    public string OrgId { get; set; }
    [JsonPropertyName("project_id")]
    public string ProjectId { get; set; }
    [JsonPropertyName("output_format")]
    public string OutputFormat { get; set; } = "v1.1";
    [JsonPropertyName("expiration_date")]
    public string ExpirationDate { get; set; }
    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; set; }
    [JsonPropertyName("version")]
    public string Version { get; } = "v2";
}

/// <summary>
/// Messages content for adding to Mem0
/// </summary>
public class MessageContent
{
    [JsonPropertyName("role")]
    public string Role { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }
}
