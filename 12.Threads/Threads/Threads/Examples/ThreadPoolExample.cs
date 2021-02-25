using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Examples
{
    public static class ThreadPoolExample
    {
        public static void ShowThreadPool()
        {
            Console.WriteLine("Start");
            Report();

            // Queue first task to run in ThreadPool
            ThreadPool.QueueUserWorkItem(new WaitCallback(SomeTask));
            Report();

            // Queue second task to run in ThreadPool
            ThreadPool.QueueUserWorkItem(SomeTask);
            Report();

            Thread.Sleep(3000);
            Console.WriteLine("Finish");
            Report();
        }

        private static void SomeTask(Object state)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is started ");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is over");
        }

        private static void Report()
        {
            Thread.Sleep(200);
            int availableWorkThreads, availableIoThreads, maxWorkThreads, maxIoThreads;
            ThreadPool.GetAvailableThreads(out availableWorkThreads, out availableIoThreads);
            ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIoThreads);

            Console.WriteLine("Available thread in pool    :{0} from {1}", availableWorkThreads, maxWorkThreads);
            Console.WriteLine("Available IO thread in pool :{0} from  {1}\n", availableIoThreads, maxIoThreads);
        }



        public static void ShowThreadPoolWithParameters()
        {
            ThreadPool.QueueUserWorkItem(SomeTaskWithParameters, "example");
        }

        private static void SomeTaskWithParameters(Object state)
        {
            Console.WriteLine($"Parameter value is {state}");
            Thread.Sleep(2000);
        }
    }
}
