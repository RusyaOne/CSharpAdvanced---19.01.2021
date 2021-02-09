using Serialization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialization.Examples
{
    public static class SimpleJsonSerizalization
    {
        public static void ShowJsonSerialization()
        {
            Human human = new Human();
            human.Name = "Uther";
            human.Age = 42;

            string json = JsonSerializer.Serialize<Human>(human);

            Console.WriteLine(json);
        }

        public static void ShowSerializerOptions()
        {
            Human human = new Human();
            human.Name = "Uther";
            human.Age = 42;

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize<Human>(human, options);

            Console.WriteLine(json);
        }


        public static void ShowSerializedAttributes()
        {
            Ork ork = new Ork();
            ork.Name = "Thrall";
            ork.Age = 56;

            string json = JsonSerializer.Serialize<Ork>(ork);

            Console.WriteLine(json);
        }
    }
}
