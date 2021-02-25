using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelClass.Examples
{
    public static class ParallelLinqExample
    {
        public static void ShowParallelLinq()
        {
            int[] array = new int[100000000];

            Parallel.For(0, 100000000, (i) => array[i] = i);

            // Set some negative values
            array[1000] = -1;
            array[14000] = -2;
            array[15000] = -3;
            array[676000] = -4;
            array[8024540] = -5;
            array[9908000] = -6;

            Stopwatch timer = new Stopwatch();

            //Find values with parallel LINQ
            timer.Start();
            var negatives = array.AsParallel().Where(element => element < 0);

            //ParallelQuery<int> negatives = from element in array.AsParallel()
            //                               where element < 0
            //                               select element;
            timer.Stop();

            Console.WriteLine($"Parallel LINQ execution time {timer.ElapsedMilliseconds}");
            timer.Reset();


            //Find values with simple LINQ
            timer.Start();
            var simpleNegatives = array.Where(element => element < 0);
            timer.Stop();

            Console.WriteLine($"Simple LINQ execution time {timer.ElapsedMilliseconds}");


            foreach (var element in negatives)
                Console.Write(element + " ");

            foreach (var element in simpleNegatives)
                Console.Write(element + " ");
        }
    }
}