namespace tcortega.AuthGG.Client.DTOs
{
    public class BasePayload
    {
        public string Type { get; set; }
        public string Aid { get; set; }
        public string Secret { get; set; }
        public string ApiKey { get; set; }
    }
}
