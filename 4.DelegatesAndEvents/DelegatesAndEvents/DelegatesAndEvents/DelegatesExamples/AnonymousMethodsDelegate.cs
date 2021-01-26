using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegatesExamples
{
    public static class AnonymousMethodsDelegate
    {
        delegate void MessageDelegate();

        public static void ShowAnonymousMethod()
        {
            MessageDelegate messageDelegate = delegate 
            {
                var value = SomeMethod();
                Console.WriteLine("This is anonymous method");
            };

            messageDelegate();
        }

        private static int SomeMethod()
        {
            return 5;
        }



        delegate int SumDelegate(int a, int b);

        public static void MethodWithReturnType()
        {
            SumDelegate sumDelegate = delegate (int x, int y)
            {
                return x + y;
            };


            Console.WriteLine(sumDelegate(4,5));
        }
    }
}
