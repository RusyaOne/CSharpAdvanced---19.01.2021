using System;
using System.Collections.Generic;
using System.Collections;

namespace UserCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection collection = new UserCollection(0, 1, 2, 3, 4, 5, 6, 7, 8);

            foreach (var element in collection)
                Console.WriteLine(element);

            //Массив можно использовать в цикле foreach, 
            //потому что класс Array тоже реализует интерфейсы IEnumerable и IEnumerator
            //а когда мы создаем массив используя квадратные скобки мы неявно используем наследника класса Array
            //Array array = new int[] { 1, 2, 3, 4 };

            //foreach (var element in array)
            //    Console.WriteLine(element);

            Console.Read();
        }
    }
}
