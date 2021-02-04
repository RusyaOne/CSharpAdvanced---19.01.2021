using LINQ.HelpMaterial;
using System;
using System.Linq;

namespace LINQ.LinqExamples
{
    public static class JoinClause
    {
        public static void ShowJoinWithQuerySyntax()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var joinResult = from character in characters
                             join story in stories
                             on character.StoryId equals story.Id
                             select new 
                             { 
                                 character.FirstName,
                                 character.LastName,
                                 StoryName = story.Name 
                             };

            foreach (var item in joinResult)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.StoryName}");
            }
        }

        public static void ShowJoinWithExtensionMethodsSyntax()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var joinResult = characters.Join(stories,
                character => character.StoryId,
                story => story.Id,
                (character, story) => new
                {
                    character.FirstName,
                    character.LastName,
                    StoryName = story.Name
                });

            foreach (var item in joinResult)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.StoryName}");
            }
        }
    }
}
