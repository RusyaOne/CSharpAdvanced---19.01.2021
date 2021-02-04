using EntityFrameworkCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EntityFrameworkCoreExample
{
    public class CSharpAdvancedContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CSharpAdvancedContext"].ConnectionString);
        }
    }
}