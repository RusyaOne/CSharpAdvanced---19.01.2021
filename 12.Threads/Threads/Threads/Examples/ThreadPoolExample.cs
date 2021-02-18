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
            int availableWorkThreads, availableIOThreads, maxWorkThreads, maxIOThreads;
            ThreadPool.GetAvailableThreads(out availableWorkThreads, out availableIOThreads);
            ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);

            Console.WriteLine("Available thread in pool    :{0} from {1}", availableWorkThreads, maxWorkThreads);
            Console.WriteLine("Available IO thread in pool :{0} from  {1}\n", availableIOThreads, maxIOThreads);
        }
    }
}
