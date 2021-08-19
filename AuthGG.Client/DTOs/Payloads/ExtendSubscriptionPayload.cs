namespace tcortega.AuthGG.Client.DTOs
{
    public class RegisterPayload : BasePayload
    {
        public string Hwid { get; set; }
        public string Email { get; set; }
        public string License { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
