using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Threads.Services.ThreadsService;

namespace AsyncDelegates.Examples
{
    public static class AsyncActionExample
    {
        public static void ShowAsyncAction()
        {
            Action myDelegate = new Action(WriteThreadNumber);

            //Invoke delagate asynchronously
            myDelegate.BeginInvoke(null, null); 

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.Write("*");
            }
        }

        public static void ShowEndInvoke()
        {
            Action myDelegate = new Action(WriteThreadNumber);

            //Invoke delagate asynchronously
            IAsyncResult result = myDelegate.BeginInvoke(null, null);

            myDelegate.EndInvoke(result); //Equals to .Join()

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.Write("*");
            }
        }
    }
}
