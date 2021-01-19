using System;
using System.Collections.Generic;

namespace GenericCollections.GenericCollectionExamples
{
    public static class LinkedListExample
    {
        public static void ShowLinkedList()
        {
            LinkedList<string> daysOfWeek = new LinkedList<string>();

            // Добавлять элемент в связный список мы можем 4 способами
            daysOfWeek.AddFirst("Monday");

            daysOfWeek.AddAfter(daysOfWeek.Last, "Tuesday");
            daysOfWeek.AddAfter(daysOfWeek.Last, "Thursday");

            daysOfWeek.AddBefore(daysOfWeek.Last, "Wednesday");

            daysOfWeek.AddLast("Friday");

            // Т.к. каждый элемент LinkedList является обьектом LinkedListNode, который содержит значение и ссылки
            // на предыдущий и последующий элемент, для итерации необходимо использовать переменную,
            // с помощью которой мы будем помнить какой текущий элемент списка  
            LinkedListNode<string> currentNode = daysOfWeek.First;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public static void RemoveNode()
        {
            LinkedList<string> daysOfWeek = new LinkedList<string>();

            daysOfWeek.AddFirst("Monday");
            daysOfWeek.AddAfter(daysOfWeek.Last, "Tuesday");
            daysOfWeek.AddAfter(daysOfWeek.Last, "Wednesday");
            daysOfWeek.AddAfter(daysOfWeek.Last, "Thursday");
            daysOfWeek.AddAfter(daysOfWeek.Last, "Friday");

            // Удаляем элементы 3 способами
            daysOfWeek.Remove(daysOfWeek.First);
            daysOfWeek.RemoveFirst();
            daysOfWeek.RemoveLast();

            LinkedListNode<string> currentNode = daysOfWeek.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

    }
}
