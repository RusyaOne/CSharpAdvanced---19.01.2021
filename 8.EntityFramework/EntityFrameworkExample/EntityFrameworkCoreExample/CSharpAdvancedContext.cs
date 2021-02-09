using EntityFrameworkCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreExample
{
    public class CSharpAdvancedContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UKR-RUSLANAN;Database=CSharpAdvanced;Trusted_Connection=SSPI");
        }
    }
}