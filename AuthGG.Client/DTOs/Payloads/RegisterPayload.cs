using System;
using System.Collections.Generic;
using System.Text;

namespace tcortega.AuthGG.Client.DTOs.Payloads
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
