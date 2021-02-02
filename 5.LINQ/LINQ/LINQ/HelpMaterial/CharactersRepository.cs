using System.Collections.Generic;

namespace LINQ.HelpMaterial
{
    public static class CharactersRepository
    {
        public static List<Character> GetCharacters()
        {
            var persons = new List<Character>();

            persons.Add(new Character("Finn", "Mertens", true, 14));
            persons.Add(new Character("Philip", "Fry", true, 25));
            persons.Add(new Character("Arwen", "Menethil", false, 2700));
            persons.Add(new Character("Audrey", "Hepburn", false, 29));
            persons.Add(new Character("John", "Wick", true, 42));
            persons.Add(new Character("Anakin", "Skywalker", true, 29));
            persons.Add(new Character("Princess", "Bubblegum", false, 827));
            persons.Add(new Character("Svetlana", "Sokolova", false, 45));
            persons.Add(new Character("Varian", "Wrynn", true, 42));

            return persons;
        }
    }
}