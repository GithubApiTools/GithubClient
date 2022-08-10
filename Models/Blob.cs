using System.Text.Json.Serialization;

namespace GithubClient.Models
{
    public class Blob
    {
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }
        [JsonPropertyName("size")]
        public int Size { get; set; }
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        [JsonPropertyName("content")]
        public string? Content { get; set; }
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }
    }
}