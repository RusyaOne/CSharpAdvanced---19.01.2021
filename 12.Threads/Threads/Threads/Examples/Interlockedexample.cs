using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Examples
{
    public static class InterlockedExample
    {
        static long counter;
        static object block = new object();

        public static void ShowLock()
        {
            Console.WriteLine("Expected counter value = 10000000");

            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; ++i)
                (threads[i] = new Thread(MethodWitInterlock)).Start(); //ChangeMethods

            for (int i = 0; i < 10; ++i)
                threads[i].Join();

            Console.WriteLine($"Real counter value = {counter}");
        }

        private static void MethodWithLock()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (block)
                {
                    counter++;
                }
            }
        }

        private static void MethodWitInterlock()
        {
            for (int i = 0; i < 1000000; i++)
                Interlocked.Increment(ref counter);           
        }
    }
}