using tcortega.AuthGG.Client.DTOs.Payloads;

namespace tcortega.AuthGG.Client.DTOs
{
    class LoginPayload : BasePayload
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Hwid { get; set; }
    }
}
