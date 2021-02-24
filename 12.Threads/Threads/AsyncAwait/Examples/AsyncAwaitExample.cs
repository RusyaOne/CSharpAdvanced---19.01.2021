using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait.Examples
{
    public static class AsyncAwaitExample
    {
        public static async void ShowAsyncAwait()
        {
            Console.WriteLine("Main started");
            await RunOperationAsync();  
            Console.WriteLine("Main finished");
        }

        private static async Task RunOperationAsync()
        {
            Console.WriteLine("ShowAsyncAwait started");
            await SomeOperation();
            Console.WriteLine("ShowAsyncAwait finished"); 
        }

        private static async Task SomeOperation()
        {
            Console.WriteLine("SomeOperation started");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("SomeOperation finished");
        }
    }
}