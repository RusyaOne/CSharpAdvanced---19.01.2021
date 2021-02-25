using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait.Examples
{
    public static class AsyncVsTask
    {
        public static void ShowAsyncVsTask()
        {
            ShowAsync();
            ShowTask();
        }

        private static async void ShowAsync()
        {
            Console.WriteLine($"ShowAsync started and is performed in {Thread.CurrentThread.ManagedThreadId} thread");
            await RunOperationAsync();
            Console.WriteLine("ShowAsync finished");
        }

        private static async Task RunOperationAsync()
        {
            Console.WriteLine($"RunOperationAsync started and is performed in {Thread.CurrentThread.ManagedThreadId} thread");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("RunOperationAsync finished");
        }

        private static void ShowTask()
        {
            Console.WriteLine($"ShowTask started and is performed in {Thread.CurrentThread.ManagedThreadId} thread");
            Task.Run(() => RunOperationWithTask());
            Console.WriteLine("ShowTask finished");
        }

        private static async Task RunOperationWithTask()
        {
            Console.WriteLine($"RunOperationWithTask started and is performed in {Thread.CurrentThread.ManagedThreadId} thread");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("RunOperationWithTask finished");
        }
    }
}