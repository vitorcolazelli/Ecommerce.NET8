using Ecommerce.Services.AuthAPI.Models.Dto;

namespace Ecommerce.Services.AuthAPI.Services.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegisterationRequestDto registerationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}
