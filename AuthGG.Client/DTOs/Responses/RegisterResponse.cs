namespace tcortega.AuthGG.Client.DTOs
{
    public class RegisterResponse : BaseResponse
    {
        public override bool IsSuccess { get => Result == "success"; }
    }
}
