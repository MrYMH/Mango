namespace Mango.Services.AuthApi.Models.Dtos
{
    public class RegisterationRequestDto : RegisterUserDto
    {
        public string? Role { get; set; }
    }
}
