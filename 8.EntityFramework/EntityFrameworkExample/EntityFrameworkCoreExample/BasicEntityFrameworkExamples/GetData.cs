using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFrameworkCoreExample.BasicEntityFrameworkExamples
{
    public static class GetData
    {
        public static void GetCharactersFromDb()
        {
            var dbContext = new CharactersDbContext();            

            foreach (var c in dbContext.Characters)            
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");                     
        }

        public static void GetDependentDataWithExplicitLoading()
        {
            var dbContext = new CharactersDbContext();
            var characters = dbContext.Characters
                .Select(x => 
                    new
                    {
                        x.FirstName,
                        x.LastName,
                        StoryName = x.Story.Name
                    });

            foreach (var c in characters)
                Console.WriteLine($"FirstName: {c.FirstName}  \tLastName: {c.LastName}  \tStory: {c.StoryName}");
        }

        public static void GetDependentDataWithEagerLoading()
        {
            var dbContext = new CharactersDbContext();
            var characters = dbContext.Characters.Include(x => x.Story);

            foreach (var c in characters)
                Console.WriteLine($"FirstName: {c.FirstName}  \tLastName: {c.LastName}  \tStory: {c.Story.Name}");
        }

        public static void GetDependentDataWithLazyLoading()
        {
            var dbContext = new CharactersDbContext();
            var characters = dbContext.Characters;

            foreach (var c in characters)
                Console.WriteLine($"FirstName: {c.FirstName}  \tLastName: {c.LastName}  \tStory: {c.Story.Name}");
        }
    }
}