using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Examples
{
    public static class MultipleParametersExample
    {
        public static void ShowMultipleParameters()
        {
            Task<int> task = new Task<int>(() => { return Sum(3, 4); });
            task.Start();

            Console.WriteLine(task.Result);
        }

        private static int Sum(int x, int y)
        {
            return x + y;
        }

    }
    
}
