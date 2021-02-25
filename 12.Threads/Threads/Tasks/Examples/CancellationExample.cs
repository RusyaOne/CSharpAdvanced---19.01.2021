using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks.Examples
{
    public static class CancellationExample
    {
        public static void ShowCancellation()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            Task task = new Task(() => SomeTask(cancellationToken));
            task.Start();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            cancellationTokenSource.Cancel();
        }

        private static void SomeTask(CancellationToken cancellationToken)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Thread Id: {threadId}");

            while (!cancellationToken.IsCancellationRequested)
            {
                Thread.Sleep(50);
                Console.Write(threadId);
            }

            Console.WriteLine($"\nThread {threadId} is over");
        }
    }
}