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
                    Account<string> genericAccount = new Account<string>("5");
                    genericAccount.ShowSum();
                    genericAccount.GetSum();
                    break;
                case ExamplesEnumeration.DoubleGenericAccount:
                    //MyClass myClass = new MyClass();
                    //myClass.Id = 1;
                    Account<string, int> doubleGenericAccount = new Account<string, int>("first", 332);
                    //Account<string, string> doubleGenericAccountSecond = new Account<string, string>("first", "second");
                    //doubleGenericAccount.ShowData();
                    var result = doubleGenericAccount.GetData();
                    Console.WriteLine(result.Item1 + ", " + result.Item2);
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
