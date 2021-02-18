using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDelegates.Examples
{
    public static class WaitForAsyncExample
    {
        public static void ShowWaitAsync()
        {
            Func<int, int, int> myDelegate = (x, y) =>
            {
                Thread.Sleep(3000);
                return x + y;
            };

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            Console.WriteLine("Main thread is paused");
   
            asyncResult.AsyncWaitHandle.WaitOne(); // Pause main thread

            Console.WriteLine("Main thread continued to work");

            int result = myDelegate.EndInvoke(asyncResult);
            Console.WriteLine("\nResult: " + result);
        }

        public static void ShowIsComplited()
        {
            Func<int, int, int> myDelegate = (x, y) =>
            {
                Thread.Sleep(3000);
                return x + y;
            };

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            // Loop will work till async task is finished
            while (!asyncResult.IsCompleted)
            {
                Thread.Sleep(100);
                Console.Write("*");
            }

            int result = myDelegate.EndInvoke(asyncResult);

            Console.WriteLine("\nResult: " + result);
        }
    }
}
