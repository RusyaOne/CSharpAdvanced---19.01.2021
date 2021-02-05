using LINQ.HelpMaterial;
using System;

namespace LINQ.LinqExamples
{
    public static class DynamicTypes
    {
        public static void ShowDynamicTypes()
        {
            dynamic everything = 1;

            Console.WriteLine(everything);

            everything = "One";

            Console.WriteLine(everything);

            everything = everything + 2;

            Console.WriteLine(everything);

            everything = new Character("Saitama", null, true, 19, 3, "Cool story, Bob");

            Console.WriteLine(everything.ToString());
        }

        //Напишите метод с возвращаемым типом dynamic и который принимает строку,
        //в зависимости от значения входящего параметра метод
        //должен возвращаться разный тип., 
        //например "string" -> строку, "int" -> целое число, "Person" -> new Person
    }
}
