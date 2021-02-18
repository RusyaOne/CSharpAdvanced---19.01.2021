using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Examples
{
    public static class GlobalVariableExample
    {
        //[ThreadStatic] 
        private static int counter;

        public static void ShowGlobalVariable()
        {
            Thread thread = new Thread(CreateNewThreads);
            thread.Start();
            thread.Join();

            Console.WriteLine("Main thread is over");
        }

        private static void CreateNewThreads()
        {
            if (counter < 10)
            {
                counter++; 
                Console.WriteLine($"Counter: {counter} Thread {Thread.CurrentThread.ManagedThreadId} is started");

                Thread thread = new Thread(CreateNewThreads);
                thread.Start();
                thread.Join();      
            }

            Console.WriteLine($"Thread {Thread.CurrentThread.GetHashCode()} is over");
        }
    }
}
