using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threads.Examples;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ThreadPoolWithParameter;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.SecondThread:
                    SecondThreadExample.ShowSecondThread();
                    break;
                case ExamplesEnumeration.Join:
                    JoinExamples.ShowJoin();
                    break;
                case ExamplesEnumeration.JoinFromSecondaryThread:
                    JoinExamples.ShowJoinFromSecondaryThread();
                    break;
                case ExamplesEnumeration.GlobalVariable:
                    GlobalVariableExample.ShowGlobalVariable();
                    break;
                case ExamplesEnumeration.Abort:
                    AbortExample.ShowAbort();
                    break;
                case ExamplesEnumeration.Monitor:
                    MonitorExample.ShowMonitor();
                    break;
                case ExamplesEnumeration.Interlocked:
                    InterlockedExample.ShowLock();
                    break;
                case ExamplesEnumeration.ThreadPool:
                    ThreadPoolExample.ShowThreadPool();
                    break;
                case ExamplesEnumeration.ThreadPoolWithParameter:
                    ThreadPoolExample.ShowThreadPoolWithParameters();
                    break;
            }

            Console.Read();
        }
    }
}