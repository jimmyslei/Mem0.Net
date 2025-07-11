using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.Net.Models;

public class FeedbackRequest
{
    [JsonPropertyName("memory_id")]
    public long MemoryId { get; set; }
    [JsonPropertyName("feedback")]
    public string Feedback { get; set; }
    [JsonPropertyName("feedback_reason")]
    public string FeedbackReason { get; set; }

}
