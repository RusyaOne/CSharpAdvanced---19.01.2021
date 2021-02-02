using System;
using System.Linq;
using LINQ.HelpMaterial;

namespace LINQ.LinqExamples
{
    public static class BasicSyntax
    {
        public static void ShowBasicSyntaxLinq()
        {
            var characters = CharactersRepository.GetCharacters();

            var adults = from character in characters
                         where character.Age > 20
                         select character;

            foreach (var adult in adults)            
                Console.WriteLine(adult.ToString());            
        }

        public static void ShowConditionWithGender()
        {
            var characters = CharactersRepository.GetCharacters();

            var adults = from character in characters
                         where character.Gender == true
                         select character;

            foreach (var adult in adults)            
                Console.WriteLine(adult.ToString());            
        }

        public static void SelectCharactersWithSameFirstAndLastNameLenth()
        {
            var characters = CharactersRepository.GetCharacters();

            var adults = from character in characters
                         where character.FirstName.Length == character.LastName.Length
                         select character;

            foreach (var adult in adults)
                Console.WriteLine(adult.ToString());
        }
    }
}