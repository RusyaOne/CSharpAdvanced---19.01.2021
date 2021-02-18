using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Examples
{
    public static class AbortExample
    {
        public static void ShowAbort()
        {
            Thread thread = new Thread(CatchAbort);
            thread.Start();

            Thread.Sleep(3000); //Delay in main thread

            thread.Abort(); //Abort thread

            Console.WriteLine("\nMain thread is over");
        }

        private static void CatchAbort()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(10);
                    Console.Write("*");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
            }

            Console.WriteLine($"\nThread {Thread.CurrentThread.GetHashCode()} is over");
        }
    }
}
