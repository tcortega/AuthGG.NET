namespace tcortega.AuthGG.Client.DTOs
{
    public class ChangePasswordResponse : BaseResponse
    {
        public override bool IsSuccess { get => Result == "success"; }
    }
}
