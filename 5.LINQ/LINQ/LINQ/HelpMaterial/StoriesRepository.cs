using System.Collections.Generic;

namespace LINQ.HelpMaterial
{
    public static class StoriesRepository
    {
        public static IEnumerable<Story> GetStories()
        {
            var stories = new List<Story>();

            stories.Add(new Story(1, "Fairy tail of the lost needle"));
            stories.Add(new Story(2, "Foundation"));
            stories.Add(new Story(3, "Cool story, Bob"));

            return stories;
        }
    }
}