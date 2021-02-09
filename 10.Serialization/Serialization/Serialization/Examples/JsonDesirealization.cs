using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Examples
{
    public static class JsonDesirealization
    {
        public static void ShowDeserialization()
        {
            Human human = new Human();
            human.Name = "Uther";
            human.Age = 42;

            var options = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize<Human>(human, options);
            Console.WriteLine(json);

            var newHuman = JsonSerializer.Deserialize<Human>(json);
            Console.WriteLine(newHuman.Name + " " + newHuman.Age);
        }
    }
}
