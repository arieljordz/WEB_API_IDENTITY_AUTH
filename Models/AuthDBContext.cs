using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WEB_API_IDENTITY_AUTH.Models
{
    public class AuthDBContext : IdentityDbContext
    {
        public AuthDBContext(DbContextOptions<AuthDBContext> options) : base(options)
        {
        }
    }
}
