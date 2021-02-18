using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelClass.Examples
{
    public static class ForExample
    {
        public static void ShowFor()
        {
            int[] data = new int[400000000];

            Stopwatch timer = new Stopwatch();

            timer.Start();
            for (int i = 0; i < data.Length; i++)               
                data[i] = i * i * i * i/ 100000;
            timer.Stop();

            Console.WriteLine("Initializing with regular cycle: " + timer.ElapsedTicks);
            timer.Reset();

            Action<int> transform = (int i) => { data[i] = i * i * i * i/ 100000; };

            timer.Start();
            Parallel.For(0, data.Length, transform);
            timer.Stop();

            Console.WriteLine("Initializing with Parallel cycle: " + timer.ElapsedTicks);

            Console.WriteLine("Main thread is over");
        }
    }
}
