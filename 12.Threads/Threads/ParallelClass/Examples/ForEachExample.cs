using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelClass.Examples
{
    public static class ForEachExample
    {
        public static void ShowForEach()
        {
            List<int> data = new List<int>();

            for (int i = 0; i < 40000000; i++)
                data.Add(i);

            Stopwatch timer = new Stopwatch();

            timer.Start();
            for (int i = 0; i < data.Count; i++)
                data[i] = data[i] * data[i] * data[i] * data[i] / 100000;
            timer.Stop();

            Console.WriteLine("Initializing with regular cycle: " + timer.ElapsedTicks);
            timer.Reset();

            Action<int> transform = (int i) => { data[i] = i * i * i * i / 100000; };

            timer.Start();
            Parallel.ForEach(data, x => x = x * x * x * x / 100000);
            timer.Stop();

            Console.WriteLine("Initializing with Parallel cycle: " + timer.ElapsedTicks);

            Console.WriteLine("Main thread is over");

            Console.Read();
        }
    }
}
