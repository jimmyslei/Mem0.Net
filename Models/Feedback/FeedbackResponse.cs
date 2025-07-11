using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mem0.Net.Models;

public class FeedbackResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("feedback")]
    public string Feedback { get; set; }
    [JsonPropertyName("feedback_reason")]
    public string FeedbackReason { get; set; }

}
