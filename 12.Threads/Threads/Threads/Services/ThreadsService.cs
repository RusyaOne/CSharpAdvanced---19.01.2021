using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Services
{
    public static class ThreadsService
    {
        public static void WriteThreadNumber()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Thread Id: {threadId}");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.Write(threadId);
            }

            Console.WriteLine($"\nThread {threadId} is over");
        }

        public static void WriteAnyChar(object charToWrite)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Thread {threadId} is started");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.Write(charToWrite?.ToString());
            }

            Console.WriteLine($"\nThread {threadId} is over");
        }
    }
}
