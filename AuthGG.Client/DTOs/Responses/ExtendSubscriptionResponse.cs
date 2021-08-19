namespace tcortega.AuthGG.Client.DTOs
{
    public class ExtendSubscriptionResponse : BaseResponse
    {
        public override bool IsSuccess { get => Result == "success"; }
    }
}
