using System;
using System.Collections;

namespace Collections.CollectionsExamples
{
    class QueueExample
    {
        public static void ShowQueue()
        {
            Queue humsters = new Queue();

            humsters.Enqueue("John");
            humsters.Enqueue("Carter");
            humsters.Enqueue("Abraham");
            humsters.Enqueue("Gon");

            //Реализация очереди в C# позволяет перебирать элементы в цикле
            foreach (var humster in humsters)
            {
                //Элементы выводятся в том порядке, в котором они бы доставались со очереди
                Console.WriteLine(humster);
            }
        }

        public static void DequeueElement()
        {
            Queue humsters = new Queue();

            humsters.Enqueue("John");
            humsters.Enqueue("Carter");
            humsters.Enqueue("Abraham");
            humsters.Enqueue("Gon");

            var popedHumster = humsters.Dequeue();

            foreach (var humster in humsters)
            {
                Console.WriteLine(humster);
            }
        }

        public static void PeekElement()
        {
            Queue humsters = new Queue();

            humsters.Enqueue("John");
            humsters.Enqueue("Carter");
            humsters.Enqueue("Abraham");
            humsters.Enqueue("Gon");

            var popedHumster = humsters.Peek();

            foreach (var humster in humsters)
            {
                Console.WriteLine(humster);
            }
        }
    }
}
