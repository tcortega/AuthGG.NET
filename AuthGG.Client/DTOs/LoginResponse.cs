using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace tcortega.AuthGG.Client.DTOs
{
    public class LoginResponse
    {
        [JsonPropertyName("result")]
        public string Result { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("hwid")]
        public string Hwid { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("uservar")]
        public string Uservar { get; set; }

        [JsonPropertyName("rank")]
        public long Rank { get; set; }

        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("expiry")]
        public DateTimeOffset Expiry { get; set; }

        [JsonPropertyName("variables")]
        public Dictionary<string, string> Variables { get; set; }

        public bool IsSuccess { get => Result == "success"; }
    }
}
