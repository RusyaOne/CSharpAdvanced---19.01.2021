using AsyncDelegates.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.IsComplited;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.AsyncAction:
                    AsyncActionExample.ShowAsyncAction();
                    break;
                case ExamplesEnumeration.EndInvoke:
                    AsyncActionExample.ShowEndInvoke();
                    break;
                case ExamplesEnumeration.FuncAsync:
                    AsyncFuncExample.ShowAsyncFunc();
                    break;
                case ExamplesEnumeration.WaitForAsync:
                    WaitForAsyncExample.ShowWaitAsync();
                    break;
                case ExamplesEnumeration.IsComplited:
                    WaitForAsyncExample.ShowIsComplited();
                    break;
            }

            Console.Read();
        }
    }
}
