using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCoreExample.Models
{
    public class Story
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }

        public List<Character> Characters { get; set; }
    }
}