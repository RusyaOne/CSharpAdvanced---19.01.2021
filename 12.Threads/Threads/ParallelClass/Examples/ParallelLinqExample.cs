using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelClass.Examples
{
    public static class ParallelLinqExample
    {
        public static void ShowParallelLinq()
        {
            int[] array = new int[10000000];

            Parallel.For(0, 10000000, (i) => array[i] = i);

            // Set some negative values
            array[1000] = -1;
            array[14000] = -2;
            array[15000] = -3;
            array[676000] = -4;
            array[8024540] = -5;
            array[9908000] = -6;

            var negatives = array.AsParallel().Where(element => element < 0);

            //ParallelQuery<int> negatives = from element in array.AsParallel()
            //                               where element < 0
            //                               select element;

            foreach (var element in negatives)
                Console.Write(element + " ");        
        }
    }
}
