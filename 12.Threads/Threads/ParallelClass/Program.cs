using ParallelClass.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ParallelLinq;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.Invoke:
                    InvokeExamples.ShowInvoke();
                    break;
                case ExamplesEnumeration.InvokeWithOptions:
                    InvokeExamples.ShowInvokeWithOptions();
                    break;
                case ExamplesEnumeration.For:
                    ForExample.ShowFor();
                    break;
                case ExamplesEnumeration.ForEach:
                    ForEachExample.ShowForEach();
                    break;
                case ExamplesEnumeration.ParallelLinq:
                    ParallelLinqExample.ShowParallelLinq();
                    break;
            }

            Console.Read();
        }
    }
}
