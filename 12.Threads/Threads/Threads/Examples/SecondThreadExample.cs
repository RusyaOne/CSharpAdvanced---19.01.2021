using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Examples
{
    public static class SecondThreadExample
    {
        public static void ShowSecondThread()
        {
            //Create new thread
            ThreadStart threadDelegate = SecondThreadMethod;
            Thread thread = new Thread(threadDelegate);

            //Launch function in secondary thread
            thread.Start();

            //Launch function in main thread
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Main thread Id: {threadId}");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
                Console.Write('*');
            }

            Console.WriteLine("\nMain thread is over.");
        }

        private static void SecondThreadMethod()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Thread Id: {threadId}");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
                Console.Write('.');
            }

            Console.WriteLine($"\nThread {threadId} is over.");
        }
    }
}
