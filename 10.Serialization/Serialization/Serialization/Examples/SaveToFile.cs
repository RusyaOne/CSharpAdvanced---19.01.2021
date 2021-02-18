using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialization.Examples
{
    public static class SaveToFile
    {
        public static void SaveJsonToFile()
        {
            Human human = new Human();
            human.Name = "Uther";
            human.Age = 42;

            using (FileStream stream = new FileStream(@"D:\Courses\CSharpAdvanced - 19.01.2021\11.Assemblies\Lesson9Example\Human.txt", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Human>(stream, human);
            }

            Console.WriteLine("Json file is created.");
        }


        public static async void GetFromFile()
        {
            Human human;

            using (FileStream stream = new FileStream(@"D:\Courses\CSharpAdvanced - 19.01.2021\11.Assemblies\Lesson9Example\Human.txt", FileMode.Open))
            {
                human = await JsonSerializer.DeserializeAsync<Human>(stream);
            }

            Console.WriteLine(human.Name + " " + human.Age);
        }
    }
}
