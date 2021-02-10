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
                                 CharactersStoryId = character.StoryId,
                                 StoryName = story.Name,
                                 StoryId = story.Id
                             };

            foreach (var item in joinResult)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.CharactersStoryId}, " +
                    $" {item.StoryName}, {item.StoryId}");
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

        public static void ShowJoinByMultipleFields()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var joinResult = characters.Join(stories,
                character => new { Id = character.StoryId , Name = character.StoryName},
                story => new { Id = story.Id, Name = story.Name },
                (character, story) => new
                {
                    character.FirstName,
                    character.LastName,
                    StoryDescription = story.Description
                });

            foreach (var item in joinResult)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.StoryDescription}");
            }
        }

        public static void ShowJoinByMultipleFieldsWithTuple()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var joinResult = characters.Join(stories,
                character => (character.StoryId, character.StoryName),
                story => (story.Id, story.Name),
                (character, story) => new
                {
                    character.FirstName,
                    character.LastName,
                    StoryDescription = story.Description
                });

            foreach (var item in joinResult)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.StoryDescription}");
            }
        }

        public static void ShowLeftJoinQuerySyntax()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var joinResult = from characater in characters
                             join story in stories
                             on characater.StoryId equals story.Id into characterStory
                             from story in characterStory.DefaultIfEmpty()
                             select new
                             {
                                 characater.FirstName,
                                 characater.LastName,
                                 StoryName = story == null ? "No story" : story.Name
                             };

            //Select Character, that only have an existing Story
            //var joinResult = from characater in characters
            //                 join story in stories
            //                 on characater.StoryId equals story.Id
            //                 select new Character
            //                 {
            //                     FirstName = characater.FirstName,
            //                     LastName = characater.LastName,
            //                     Gender = characater.Gender,
            //                     StoryId = characater.StoryId,
            //                     StoryName = characater.StoryName,
            //                     Age = characater.Age
            //                 };

            foreach (var item in joinResult)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.StoryName}");
            }
        }

        public static void ShowLeftJoinExtensionMethodsSyntax()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var joinResult = characters.
                GroupJoin(stories,
                    character => character.StoryId,
                    story => story.Id,
                    (character, characterStories) => new
                    { 
                        character,
                        characterStories
                    }).
                SelectMany(groupJoinResult => groupJoinResult.characterStories.DefaultIfEmpty(),
                    (groupJoinResult, story) => new 
                    {
                        groupJoinResult.character.FirstName,
                        groupJoinResult.character.LastName,
                        Description = story?.Description ?? "Default description"
                    });

            foreach (var item in joinResult)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.Description}");
            }
        }
    }
}