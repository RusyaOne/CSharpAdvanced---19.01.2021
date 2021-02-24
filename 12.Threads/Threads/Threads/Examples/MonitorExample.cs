using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Examples
{
    public static class MonitorExample
    {
        static long counter;
        static object block = new object();

        public static void ShowMonitor()
        {
            Console.WriteLine("Expected counter value = 10000000");

            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; ++i)
                (threads[i] = new Thread(MethodWithMonitor)).Start(); 

            for (int i = 0; i < 10; ++i)
                threads[i].Join();

            Console.WriteLine($"Real counter value = {counter}");
        }

        private static void MethodWithMonitor()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Monitor.Enter(block);
                try
                {
                    counter++;
                }
                finally
                {
                    Monitor.Exit(block);
                }
            }
        }
    }
}
