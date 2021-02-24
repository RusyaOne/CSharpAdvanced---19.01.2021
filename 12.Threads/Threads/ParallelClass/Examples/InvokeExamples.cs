using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Threads.Services.ThreadsService;

namespace ParallelClass.Examples
{
    public static class InvokeExamples
    {
        public static void ShowInvoke()
        {
            // Run two method in parallel
            Parallel.Invoke(WriteOne, WriteTwo);

            //All operations in Parallel are NOT background
            Console.WriteLine("\nMain thread is over");
        }

        public static void ShowInvokeWithOptions()
        {
            ParallelOptions options = new ParallelOptions();

            options.MaxDegreeOfParallelism = 2;

            Console.WriteLine("Logical CPUs:" + Environment.ProcessorCount);

            // Run four methods in parallel
            Parallel.Invoke(options, WriteOne, WriteTwo, WriteThree, WriteFour);

            Console.WriteLine("\nMain thread is over");
        }

        private static void WriteOne()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.Write("1_");
            }
        }

        private static void WriteTwo()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.Write("2_");
            }
        }

        private static void WriteThree()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.Write("3_");
            }
        }

        private static void WriteFour()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.Write("4_");
            }
        }
    }
}
