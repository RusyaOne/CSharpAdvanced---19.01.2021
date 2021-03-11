using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreMvcExample.Models
{
    public class MockCharactersRepository : ICharactersRepository
    {
        public IEnumerable<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character("Finn", "Mertens", true, 14, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("Philip", "Fry", true, 25, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("Arwen", "Menethil", false, 2700, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("Audrey", "Hepburn", false, 29, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("John", "Wick", true, 42, 1, "Fairytail of the lost needle"));
            characters.Add(new Character("Anakin", "Skywalker", true, 29, 2, "Foundation"));
            characters.Add(new Character("Princess", "Bubblegum", false, 827, 4, ""));
            characters.Add(new Character("Svetlana", "Sokolova", false, 45, 4, ""));
            characters.Add(new Character("Varian", "Wrynn", true, 42, 3, "Cool story, Bob"));

            return characters;
        }

        public async Task<Character> GetSingleCharacter()
        {
            Character character;

            using (FileStream stream = new FileStream(@"D:\Courses\CSharpAdvanced - 19.01.2021\13.NetCore\Human.txt", FileMode.Open))
            {
                character = await JsonSerializer.DeserializeAsync<Character>(stream);
            }

            return character;
        }

        public void WriteCharacterToFile()
        {
            Character human = new Character("Finn", "Mertens", true, 14, 1, "Fairytail of the lost needle");

            using (FileStream stream = new FileStream(@"D:\Courses\CSharpAdvanced - 19.01.2021\13.NetCore\Human.txt", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Character>(stream, human);
            }
        }
    }
}