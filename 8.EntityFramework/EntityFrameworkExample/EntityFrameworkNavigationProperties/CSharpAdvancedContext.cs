using EntityFrameworkNavigationProperties.Models;
using System.Data.Entity;

namespace EntityFrameworkNavigationProperties
{
    public class CSharpAdvancedContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
