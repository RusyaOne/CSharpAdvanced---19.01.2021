using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Examples;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.Result;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.BasicTask:
                    TaskExample.ShowTask();
                    break;
                case ExamplesEnumeration.WithParameters:
                    TaskExample.ShowTaskWithParameters();
                    break;
                case ExamplesEnumeration.TaskStatus:
                    TaskExample.ShowTaskStatus();
                    break;
                case ExamplesEnumeration.IsBackground:
                    IsBackgroupExample.ShowIsBackground();
                    break;
                case ExamplesEnumeration.Wait:
                    WaitExample.ShowWaitTask();
                    break;
                case ExamplesEnumeration.WaitAllOrAny:
                    WaitExample.ShowWaitAllOrAny();
                    break;
                case ExamplesEnumeration.TaskFactory:
                    TaskFactoryExample.ShowTaskFactory();
                    break;
                case ExamplesEnumeration.ContinueWith:
                    TaskContinuationExample.ShowTaskContinuation();
                    break;
                case ExamplesEnumeration.Result:
                    TaskResultExample.ShowTaskResult();
                    break;
            }

            Console.Read();
        }
    }
}
