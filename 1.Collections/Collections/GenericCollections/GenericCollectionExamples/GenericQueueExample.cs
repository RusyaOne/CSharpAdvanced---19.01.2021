using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollections.GenericCollectionExamples
{
    public static class GenericQueueExample
    {
        public static void ShowGenericQueue()
        {
            Queue<int> numbers = new Queue<int>();

            //В отличии от Stack при добавлении элементов типа double не происходит упаковки (boxing)
            numbers.Enqueue(34);
            numbers.Enqueue(345);
            numbers.Enqueue(234);
            numbers.Enqueue(777);

            foreach (var humster in numbers)
            {
                Console.WriteLine(humster); //При использовании элемента не происходит распаковки (unboxing)
            }
        }

        public static void CompileTimeError()
        {
            Queue numbers = new Queue();

            numbers.Enqueue(34.5);
            numbers.Enqueue(345.03);
            numbers.Enqueue(new object());
            numbers.Enqueue(777.8);

            //Queue<double> strictNumbers = new Queue<double>();

            //strictNumbers.Enqueue(34.5);
            //strictNumbers.Enqueue(345.03);
            //strictNumbers.Enqueue(new object());
            //strictNumbers.Enqueue(777.8);

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
