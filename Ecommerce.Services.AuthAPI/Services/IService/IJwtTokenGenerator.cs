using Ecommerce.Services.AuthAPI.Models;

namespace Ecommerce.Services.AuthAPI.Services.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
