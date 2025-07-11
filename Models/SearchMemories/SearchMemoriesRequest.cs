using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.Net.Models;

public class SearchMemoriesRequest
{
    [JsonPropertyName("query")]
    public string Query { get; set; }

    [JsonPropertyName("top_k")]
    public int Limit { get; set; } = 10;

    [JsonPropertyName("filters")]
    public Dictionary<string, object> Filters { get; set; }
    [JsonPropertyName("fields")]
    public List<string> Fields { get; set; }
    [JsonPropertyName("rerank")]
    public bool Rerank { get; set; }
    [JsonPropertyName("org_id")]
    public string OrgId { get; set; }
    [JsonPropertyName("project_id")]
    public string ProjectId { get; set; }
}
