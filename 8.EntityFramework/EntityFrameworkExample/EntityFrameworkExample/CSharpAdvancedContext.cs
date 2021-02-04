using EntityFrameworkExample.Models;
using System.Data.Entity;

namespace EntityFrameworkExample
{
    public class CSharpAdvancedContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}
