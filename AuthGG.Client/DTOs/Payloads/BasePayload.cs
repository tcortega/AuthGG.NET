using System;
using System.Collections.Generic;
using System.Text;

namespace tcortega.AuthGG.Client.DTOs.Payloads
{
    public class BasePayload
    {
        public string Type { get; set; }
        public string Aid { get; set; }
        public string Secret { get; set; }
        public string ApiKey { get; set; }
    }
}
