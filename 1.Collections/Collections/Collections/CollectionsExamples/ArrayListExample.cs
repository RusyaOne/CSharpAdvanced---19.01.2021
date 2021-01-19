using System;
using System.Collections;

namespace Collections.CollectionsExamples
{
    public static class ArrayListExample
    {
        public static void ShowArrayList()
        {
            //Данные в элементах ArrayList храняться в виде обьектов
            //int [] array = new int[5]; //Пример массива
            ArrayList humans = new ArrayList();
                        
            humans.Add("Kurt Cobain");
            humans.Add("Frank Sinatra");
            humans.Add("Audrey Hepburn");
            humans.Add("Anatoliy");

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }

        public static void UseIntegers()
        {
            ArrayList humans = new ArrayList();

            //При добавлении целочисленного числа происходит упаковка (boxing)
            humans.Add(1);
            humans.Add(2);
            humans.Add(3);
            humans.Add(4);

            foreach (var human in humans)
            {
                Console.WriteLine((int)human); //При выводе числа происходит распаковка (unboxing)
            }
        }

        public static void DeleteElement()
        {
            ArrayList humans = new ArrayList();

            humans.Add("Kurt Cobain");
            humans.Add("Frank Sinatra");
            humans.Add("Audrey Hepburn");
            humans.Add("Anatoliy");

            humans.Remove("Frank Sinatra");

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }

        public static void ConstructorInitialization()
        {
            ArrayList humans = new ArrayList()
            {
                "Kurt Cobain",
                "Frank Sinatra",
                "Audrey Hepburn",
                "Anatoliy"
            };

            foreach (var human in humans)
            {
                Output(human);
            }
        }

        private static void Output(object human) =>
            Console.WriteLine(human);
    }
}
