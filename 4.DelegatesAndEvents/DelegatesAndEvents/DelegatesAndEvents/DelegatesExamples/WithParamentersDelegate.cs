using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegatesExamples
{
    delegate Cat CountDelegates(int cats);

    public static class WithParametersDelegate
    {
        public static void ShowWithParametersDelegate()
        {
            MethodsForDelegates methodsForDelegate = new MethodsForDelegates();


            CountDelegates countDelegate = methodsForDelegate.Count;

            //Cat cat = countDelegate.Invoke(5);
            Cat cat = countDelegate(5);

            cat.Meow();
        }
    }

    public class MethodsForDelegates
    {
        public Cat Count(int cats)
        {
            return new Cat(cats);
        }
    }

    public class Cat
    {
        public Cat(int cats)
        {
            Console.Write(cats + " were created.");
        }

        public void Meow()
        {
            Console.Write("Meow meow");
        }
    }
}
