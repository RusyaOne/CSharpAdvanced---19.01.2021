using System;

namespace StaticVsNotStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример статических методов
            ExampleStaticMethods exampleStatic = new ExampleStaticMethods();

            exampleStatic.NosStatic();

            ExampleStaticMethods.Static();


            //Пример статического класса
            //ExampleStaticClass exampleStaticClass = new ExampleStaticClass();
        }
    }
}