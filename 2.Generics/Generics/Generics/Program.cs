using System;
using Generics.Examples;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.DoubleGenericAccount;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.BasicAccount:
                    Account basicAccount = new Account(5);
                    basicAccount.ShowSum();
                    basicAccount.GetSum();
                    break;

                case ExamplesEnumeration.GenericAccount:
                    //Account<string> genericAccount = new Account<string>("5");
                    //Account<int> genericAccount = new Account<int>(5);
                    Account<object> genericAccount = new Account<object>(5);
                    genericAccount.ShowSum();
                    genericAccount.GetSum();
                    break;

                case ExamplesEnumeration.DoubleGenericAccount:
                    Account<string, int> doubleGenericAccount = new Account<string, int>("string", 332);
                    doubleGenericAccount.ShowData();

                    //MyClass myClass = new MyClass();
                    //myClass.Id = 1;
                    //Account<MyClass, int> doubleGenericAccount = new Account<MyClass, int>(myClass, 332);
                    break;
            }

            Console.Read();
        }
    }

    public class MyClass
    {
        public int Id { get; set; }
    }
}
