using LINQ.HelpMaterial;
using System;
using System.Linq;

namespace LINQ.LinqExamples
{
    public static class GroupByClause
    {
        public static void ShowGroupBy()
        {
            var characters = CharactersRepository.GetCharacters();

            var groups = from character in characters
                         group character by character.Gender;

            foreach (var group in groups)
                foreach (var person in group)
                    Console.WriteLine(person.ToString());
        }

        public static void GroupByExtensionSyntax()
        {
            var characters = CharactersRepository.GetCharacters();

            var groups = characters.GroupBy(x => x.Gender);

            foreach (var group in groups)
                foreach (var person in group)
                    Console.WriteLine(person.ToString());
        }

        //Напишите запрос LINQ в котором сгруппируйте персонажей по возрасту
        //выведите группы в которых больше одного персонажа

        public static void GroupByInto()
        {
            var characters = CharactersRepository.GetCharacters();

            var groups = from character in characters
                       group character by character.Age into ageGroups
                       where ageGroups.Count() > 1
                       select ageGroups;

            //var groups = characters.GroupBy(x => x.Age).Where(group => group.Count() > 1);

            foreach (var group in groups)
                foreach (var person in group)
                    Console.WriteLine(person.ToString());
        }
    }
}
