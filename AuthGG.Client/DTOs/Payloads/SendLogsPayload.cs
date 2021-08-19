
namespace tcortega.AuthGG.Client.DTOs
{
    public class SendLogsPayload : BasePayload
    {
        public string Username { get; set; }
        public string PcUser { get; set; }
        public string Action { get; set; }
    }
}
