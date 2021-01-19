using System;
using System.Collections;

namespace Collections.CollectionsExamples
{
    public static class StackExample
    {
        public static void ShowStack()
        {
            Stack humsters = new Stack();

            humsters.Push("John");
            humsters.Push("Carter");
            humsters.Push("Abraham");
            humsters.Push("Gon");

            //Реализация стека в C# позволяет перебирать элементы в цикле
            foreach (var humster in humsters)
            {
                //Элементы выводятся в том порядке, в котором они бы доставались со стека
                Console.WriteLine(humster);
            }
        }

        public static void PopElement()
        {
            Stack humsters = new Stack();

            humsters.Push("John");
            humsters.Push("Carter");
            humsters.Push("Abraham");
            humsters.Push("Gon");

            var popedHumster = humsters.Pop();

            foreach (var humster in humsters)
            {
                Console.WriteLine(humster);
            }

            //Console.WriteLine(popedHumster);
        }

        public static void PeekElement()
        {
            Stack humsters = new Stack();

            humsters.Push("John");
            humsters.Push("Carter");
            humsters.Push("Abraham");
            humsters.Push("Gon");

            var peekedHumster = humsters.Peek();

            foreach (var humster in humsters)
            {
                Console.WriteLine(humster);
            }
        }
    }
}
