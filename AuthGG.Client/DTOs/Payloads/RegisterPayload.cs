﻿namespace tcortega.AuthGG.Client.DTOs
{
    public class ExtendSubscriptionPayload : BasePayload
    {
        public string License { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
