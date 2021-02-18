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
        public static void ShowAsyncAwait()
        {
            RunOperationAsync();  

            Console.WriteLine("Main finished");
        }

        private static async void RunOperationAsync()
        {
            Console.WriteLine("ShowAsyncAwait started"); //This part runs syncronously
            await Task.Run(() => { SomeOperation(); }); //This part runs asyncronously
            Console.WriteLine("ShowAsyncAwait finished"); 
        }

        private static void SomeOperation()
        {
            Thread.Sleep(3000);
        }
    }
}
