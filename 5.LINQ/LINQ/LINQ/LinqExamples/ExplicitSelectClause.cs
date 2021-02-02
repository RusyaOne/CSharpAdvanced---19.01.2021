using LINQ.HelpMaterial;
using System;
using System.Linq;

namespace LINQ.LinqExamples
{
    public static class ExplicitSelectClause
    {
        public static void ShowExplicitSelect()
        {
            var characters = CharactersRepository.GetCharacters();

            var names = from character in characters
                         select character.FirstName;

            //var names = characters.Select(x => x.FirstName);

            foreach (var name in names)
                Console.WriteLine(name);
        }

        public static void SelectAnonymousType()
        {
            var characters = CharactersRepository.GetCharacters();

            var persons = from character in characters
                          select new
                          {
                              character.FirstName,
                              character.Age
                          };

            //var persons = characters.Select(x => new { x.FirstName, x.Age });

            foreach (var person in persons)
                Console.WriteLine($"FirstName: {person.FirstName}, \tAge: {person.Age}");
        }

        //Создайте запрос в котором выберите персонажей старше 40 лет сгрупируйте их по FirstName 
        //и выберите анонимный обьект с 2 свойствами: название группы и кол-во элементов 
    }
}
