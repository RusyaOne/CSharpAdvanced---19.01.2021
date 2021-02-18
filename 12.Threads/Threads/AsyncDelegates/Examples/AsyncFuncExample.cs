using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDelegates.Examples
{
    public static class AsyncFuncExample
    {
        public static void ShowAsyncFunc()
        {
            Func<int, int> myDelegate = x => 
            {
                Thread.Sleep(3000);
                return x * 2;
            };

            //Invoke delagate asynchronously
            var asyncResult = myDelegate.BeginInvoke(5, null, null);

            Console.WriteLine("Main thread is keep working");

            int result = myDelegate.EndInvoke(asyncResult);

            Console.WriteLine(result);
        }
    }
}
