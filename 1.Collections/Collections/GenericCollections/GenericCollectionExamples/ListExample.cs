using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollections.GenericCollectionExamples
{
    public static class ListExample
    {
        public static void ShowList()
        {
            List<int> numbers = new List<int>();

            //В отличие от ArrayList при добавлении целого числа в List<int> не происходит упаковки в обьект (boxing)
            //Это позитивно сказывается на производительности
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(8);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void CompileTimeError()
        {
            ArrayList numbers = new ArrayList();

            numbers.Add(1);
            numbers.Add("asd");

            //List<int> strictNumbers = new List<int>();

            //strictNumbers.Add(1);
            //strictNumbers.Add("asd");           


            //Использование Generic коллекции помагает прдупредить ошибку еще на этапе компиляции
            //Также позволяет проводить действия с элементами без приведения типов, ArrayList требует этого т.к. все его элементы типа object
            try
            {
                Console.WriteLine((int)numbers[0] + (int)numbers[1]);
                //Console.WriteLine(strictNumbers[0] + strictNumbers[1]); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}
