using EntityFrameworkCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EntityFrameworkCoreExample
{
    public class CharactersDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CharactersConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Story>().HasData(
                new Story { Id = 1, Name = "Foundation", Description = ""},
                new Story { Id = 2, Name = "LOTR", Description = ""},
                new Story { Id = 3, Name = "Hyperion", Description = ""});

            modelBuilder.Entity<Character>().HasData(
                new Character() { Id = 1, FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35, StoryId = 1 },
                new Character() { Id = 2, FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700, StoryId = 2},
                new Character() { Id = 3, FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14, StoryId = 3});
        }
    }
}