using AsyncAwait.Examples;
using System;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.AsyncVsTask;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.AsyncAwait:
                    AsyncAwaitExample.ShowAsyncAwait();
                    break;
                case ExamplesEnumeration.ReturnValue:
                    ReturnValueExample.ShowAsyncAwait();
                    break;
                case ExamplesEnumeration.MakeBreakfastAsync:
                    MakeBreakfastAsync.MakeBreakfast();
                    break;
                case ExamplesEnumeration.AsyncVsTask:
                    AsyncVsTask.ShowAsyncVsTask();
                    break;
            }

            Console.WriteLine("Main is finished");
            Console.Read();
        }
    }
}