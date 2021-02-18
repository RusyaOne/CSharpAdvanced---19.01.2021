using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks.Examples
{
    public static class IsBackgroupExample
    {
        public static void ShowIsBackground()
        {
            Action action = WriteInBackground;

            Task task = new Task(action);
            task.Start();

            Thread.Sleep(1000);
        }

        private static void WriteInBackground()
        {
            //Unlike default thread Tasks threads are backgroud by default
            //It is because the Task gets a thread from the ThreadPool 

            //Thread.CurrentThread.IsBackground = false;

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(30);
                Console.Write("-");
            }
        }
    }
}
