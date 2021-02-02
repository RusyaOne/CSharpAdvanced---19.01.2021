using System.Collections.Generic;

namespace LINQ.HelpMaterial
{
    public static class CharactersRepository
    {
        public static List<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character("Finn", "Mertens", true, 14));
            characters.Add(new Character("Philip", "Fry", true, 25));
            characters.Add(new Character("Arwen", "Menethil", false, 2700));
            characters.Add(new Character("Audrey", "Hepburn", false, 29));
            characters.Add(new Character("John", "Wick", true, 42));
            characters.Add(new Character("Anakin", "Skywalker", true, 29));
            characters.Add(new Character("Princess", "Bubblegum", false, 827));
            characters.Add(new Character("Svetlana", "Sokolova", false, 45));
            characters.Add(new Character("Varian", "Wrynn", true, 42));

            return characters;
        }
    }
}