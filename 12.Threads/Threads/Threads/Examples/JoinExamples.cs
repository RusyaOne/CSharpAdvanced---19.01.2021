using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Threads.Services.ThreadsService;

namespace Threads.Examples
{
    public static class JoinExamples
    {
        public static void ShowJoin()
        {
            Thread thread = new Thread(WriteChar); //No expicit ThreadStart
            thread.Start();

            //Wait for secondary thread to finish
            thread.Join();

            //Launch function in main thread
            WriteChar();
        }



        public static void ShowJoinFromSecondaryThread()
        {
            //Creating ParameterizedThreadStart to launch method with parameters
            ParameterizedThreadStart threadDelegate = RunSecondThread;
            var secondThread = new Thread(threadDelegate);

            //secondThread.IsBackground = true; //Show ForeGroud priority
            secondThread.Start("2_");
            secondThread.Join();

            //Launch from main thread
            WriteAnyChar("1_");
        }

        private static void RunSecondThread(object charToWrite)
        {
            var thirdThread = new Thread(WriteAnyChar);

            //Launch from third thread
            thirdThread.Start("3_");
            thirdThread.Join();

            //Launch from second thread
            WriteAnyChar(charToWrite);
        }
    }
}
