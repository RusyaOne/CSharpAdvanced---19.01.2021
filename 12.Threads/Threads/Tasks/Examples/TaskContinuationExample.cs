using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks.Examples
{
    public static class TaskContinuationExample
    {
        public static void ShowTaskContinuation()
        {
            Action action = new Action(WriteOne);
            Task task = new Task(action);

            //Create task continuation
            Action<Task> continuation = new Action<Task>(WriteTwo);
            Task taskContinuation = task.ContinueWith(continuation);

            task.Start();

            Console.ReadKey();
        }

        private static void WriteOne()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.Write("1");
            }
        }

        private static void WriteTwo(Task task)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.Write("2");
            }
        }
    }
}
