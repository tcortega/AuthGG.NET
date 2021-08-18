namespace tcortega.AuthGG.Client.DTOs
{
    class LoginPayload
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Hwid { get; set; }
        public string Type { get; set; }
        public string Secret { get; set; }
        public string ApiKey { get; set; }
        public string Aid { get; set; }
    }
}
