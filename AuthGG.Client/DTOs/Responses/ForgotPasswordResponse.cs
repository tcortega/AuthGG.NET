using System.Text.Json.Serialization;

namespace tcortega.AuthGG.Client.DTOs
{
    public class ForgotPasswordResponse : BaseResponse
    {
        [JsonPropertyName("info")]
        public string Info { get; set; }
        public override bool IsSuccess { get => Result == "success"; }
    }
}
