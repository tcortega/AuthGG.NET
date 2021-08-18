using System.Text.Json.Serialization;

namespace tcortega.AuthGG.Client.DTOs
{
    public class AppInfo : BaseResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("developermode")]
        public string Developermode { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("downloadlink")]
        public string Downloadlink { get; set; }

        [JsonPropertyName("freemode")]
        public string Freemode { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("register")]
        public string Register { get; set; }

        [JsonPropertyName("users")]
        public long Users { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
