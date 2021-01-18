using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollections.GenericCollectionExamples
{
    public static class GenericStackExample
    {
        public static void ShowGenericStack()
        {
            Stack<double> doubles = new Stack<double>();

            //В отличии от Stack при добавлении элементов типа double не происходит упаковки (boxing)
            doubles.Push(34.5);
            doubles.Push(345.03);
            doubles.Push(234.65);
            doubles.Push(777.8);

            foreach (var humster in doubles)
            {
                Console.WriteLine(humster); //При использовании элемента не происходит распаковки (unboxing)
            }
        }

        public static void CompileTimeError()
        {
            Stack numbers = new Stack();

            numbers.Push(34.5);
            numbers.Push(345.03);
            numbers.Push(new Stack());
            numbers.Push(777.8);

            //Stack<double> strictNumbers = new Stack<double>();

            //strictNumbers.Push(34.5);
            //strictNumbers.Push(345.03);
            //strictNumbers.Push(new Stack());
            //strictNumbers.Push(777.8);

            try
            {
                foreach (var number in numbers)
                {
                    double tmpNumber = (double)number;
                    //double tmpNumber = number;
                    Console.WriteLine(tmpNumber); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
