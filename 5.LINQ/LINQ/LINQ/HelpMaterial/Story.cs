namespace LINQ.HelpMaterial
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Story(int storyId, string storyName)
        {
            Id = storyId;
            Name = storyName;
        }

        public override string ToString()
        {
            return $"StoryId: {Id}, \tStoryName: {Name}";
        }
    }
}