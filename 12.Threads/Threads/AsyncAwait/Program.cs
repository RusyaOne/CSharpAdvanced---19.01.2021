using AsyncAwait.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ReturnValue;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.AsyncAwait:
                    AsyncAwaitExample.ShowAsyncAwait();
                    break;
                case ExamplesEnumeration.ReturnValue:
                    ReturnValueExample.ShowAsyncAwait();
                    break;
            }

            Console.Read();
        }
    }
}
