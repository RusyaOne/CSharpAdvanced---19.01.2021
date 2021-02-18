using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Threads.Services.ThreadsService;

namespace Tasks.Examples
{
    public static class TaskExample
    {
        public static void ShowTask()
        {
            Action action = WriteChar;

            Task task = new Task(action);   
            task.Start();

            WriteChar();
        }

        public static void ShowTaskWithParameters()
        {
            Action<object> action = WriteAnyChar;

            Task task = new Task(action, "9");
            task.Start();

            WriteChar();
        }

        public static void ShowTaskStatus()
        {
            Task task = new Task(WriteChar);
            Console.WriteLine("1. " + task.Status); 

            task.Start();
            Console.WriteLine("2. " + task.Status); 

            Thread.Sleep(1000);
            Console.WriteLine("\n3. " + task.Status); 

            Thread.Sleep(5000);
            Console.WriteLine("\n4. " + task.Status); 
        }
    }
}
