using Microsoft.EntityFrameworkCore;
using PropertyPro.Data.Entities;

namespace PropertyPro.Data.DatabaseContexts.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Property> Properties { get; set;}
         public DbSet<contact> Contacts { get; set;}
         
    }
}