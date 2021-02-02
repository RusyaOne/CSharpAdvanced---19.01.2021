using LINQ.HelpMaterial;
using System;
using System.Linq;

namespace LINQ.LinqExamples
{
    public static class WhereClause
    {
        public static void ShowWhereWithBasicSyntax()
        {
            var characters = CharactersRepository.GetCharacters();

            var persons = from character in characters
                          where character.FirstName.StartsWith("A") && 
                                !character.LastName.StartsWith("S")
                          select character;

            foreach (var person in persons)            
                Console.WriteLine(person.ToString());            
        }

        public static void ShowWhereWithExtensionSyntax()
        {
            var characters = CharactersRepository.GetCharacters();

            var persons = characters.Where(x => x.FirstName.StartsWith("A") || x.LastName.Length == 5);

            foreach (var person in persons)           
                Console.WriteLine(person.ToString());            
        }

        //Напишите сами LINQ запрос с оператором Where,
        //используя синтаксис методов расширения 
        //и используйте в выражении оба логических оператора && и || 
    }
}
