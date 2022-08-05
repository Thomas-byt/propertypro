using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PropertyPro.Data.Entities;

namespace PropertyPro.Data.DatabaseContexts.AuthenticationDbContext
{



    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
        : base (options)
        {
            
        }
    }

}

 