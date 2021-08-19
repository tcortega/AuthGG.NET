using System.Text.Json.Serialization;

namespace tcortega.AuthGG.Client.DTOs
{
    public class BaseResponse
    {
        [JsonPropertyName("result")]
        public string Result { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        public virtual bool IsSuccess { get => Result != "failed"; }
    }
}
