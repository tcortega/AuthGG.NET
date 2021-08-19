namespace tcortega.AuthGG.Client.DTOs
{
    class ChangePasswordPayload : BasePayload
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }
}
