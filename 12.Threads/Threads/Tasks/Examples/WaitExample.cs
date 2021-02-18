using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Threads.Services.ThreadsService;

namespace Tasks.Examples
{
    public static class WaitExample
    {
        public static void ShowWaitTask()
        {
            Task task = new Task(WriteChar);
            task.Start();

            Console.WriteLine("\ntask.IsCompleted = " + task.IsCompleted);
                        
            // Option 1:
            task.Wait(); //Analogy of .Join()

            // Option 2:
            //while (!task.IsCompleted) 
            //   Thread.Sleep(100);


            Console.WriteLine("\ntask.IsCompleted = " + task.IsCompleted);
        }





        public static void ShowWaitAllOrAny()
        {
            Task task1 = new Task(RunTaskWithDelay, 3);
            Task task2 = new Task(RunTaskWithDelay, 5);

            task1.Start();
            task2.Start();

            Task.WaitAll(task1, task2);
            //Task.WaitAny(task1, task2);

            Console.WriteLine("Main thread is over");
        }

        private static void RunTaskWithDelay(object seconds)
        {
            Thread.Sleep((int)seconds * 1000);
            Console.WriteLine($"Task in thread {Thread.CurrentThread.ManagedThreadId} is completed");
        }
    }
}
