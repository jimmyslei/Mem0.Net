using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.NetCore.Models;

public class GetMemoriesRequest
{
    [JsonPropertyName("fields")]
    public List<string> Fields { get; set; }
    [JsonPropertyName("filters")]
    public Dictionary<string,object> Filters { get; set; }
    [JsonPropertyName("org_id")]
    public string OrgId { get; set; }
    [JsonPropertyName("project_id")]
    public string ProjectId { get; set; }
    [JsonPropertyName("page")]
    public int Page { get; set; } = 1;
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; } = 10;
}
