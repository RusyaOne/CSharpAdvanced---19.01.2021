using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcExample.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public int StoryId { get; set; }
        public string StoryName { get; set; }

        public Character(string firstName, string lastName, bool gender, int age, int storyId, string storyName)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            StoryId = storyId;
            StoryName = storyName;
        }
    }
}