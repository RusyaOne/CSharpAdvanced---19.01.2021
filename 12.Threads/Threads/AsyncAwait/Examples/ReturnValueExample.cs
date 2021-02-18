using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait.Examples
{
    public static class ReturnValueExample
    {
        public static void ShowAsyncAwait()
        {
            RunOperationAsync();

            Console.WriteLine("Main finished");
        }

        private static async void RunOperationAsync()
        {
            Console.WriteLine("ShowAsyncAwait started"); //This part runs syncronously
            int sum = await Task<int>.Run(() => Sum(1, 2)); //This part runs asyncronously
            Console.WriteLine($"ShowAsyncAwait finished. Sum: {sum}");
        }

        private static int Sum(int x, int y)
        {
            return x + y;
        }

    }
}
