using EntityFrameworkLesson.Models;
using System.Data.Entity;

namespace EntityFrameworkLesson
{
    public class CinemaContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}
