using Microsoft.AspNetCore.Identity;
using System.Data.Common;

namespace Ecommerce.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
