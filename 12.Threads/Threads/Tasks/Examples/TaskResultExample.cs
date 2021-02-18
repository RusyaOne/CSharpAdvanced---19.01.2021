using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Examples
{
    public static class TaskResultExample
    {
        public static void ShowTaskResult()
        {
            Task<int> task = new Task<int>(Square, 2);
            task.Start();

            Console.WriteLine(task.Result);
        }

        private static int Square(object x)
        {
            return (int)x * (int)x;
        }
    }
}
