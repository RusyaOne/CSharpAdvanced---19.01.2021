using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait.Examples
{
    public static class ReturnValueExample
    {
        public static async void ShowAsyncAwait()
        {
            await RunOperationAsync();

            Console.WriteLine("Main finished");
        }

        private static async Task RunOperationAsync()
        {
            Console.WriteLine("ShowAsyncAwait started");
            int sum = await Sum(4, 5);
            Console.WriteLine($"ShowAsyncAwait finished. Sum: {sum}");
        }

        private static async Task<int> Sum(int x, int y)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return  x + y;
        }
    }
}