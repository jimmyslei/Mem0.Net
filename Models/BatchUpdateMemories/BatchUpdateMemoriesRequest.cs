using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.Net.Models;

public class BatchUpdateMemoriesRequest
{
    [JsonPropertyName("memories")]
    public List<BatchUpdateMemoriesRequestData> Memories { get; set; }
    
}

public class BatchUpdateMemoriesRequestData
{
    [JsonPropertyName("memory_id")]
    public long MemoryId { get; set; }
    [JsonPropertyName("text")]
    public string Text { get; set; }
}
