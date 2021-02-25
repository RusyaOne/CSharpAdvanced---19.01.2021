using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelClass.Examples
{
    public static class ForEachExample
    {
        public static void ShowForEach()
        {
            //Creating new collection
            List<int> data = new List<int>();

            for (int i = 0; i < 100000000; i++)
                data.Add(i);

            Stopwatch timer = new Stopwatch();

            //Performing calculations in simple foreach
            timer.Start();
            foreach (var i in data)            
                PerformUselessCalcucation(i);            
            timer.Stop();

            Console.WriteLine("Initializing with regular cycle: " + timer.ElapsedMilliseconds);
            timer.Reset();


            //Performing calculations in parallel foreach
            timer.Start();
            Parallel.ForEach(data, x => PerformUselessCalcucation(x));
            timer.Stop();

            Console.WriteLine("Initializing with Parallel cycle: " + timer.ElapsedMilliseconds);



            void PerformUselessCalcucation(int x)
            {
                var uselessVariable = x * x * x * x / 100000;
            }
        }
    }
}