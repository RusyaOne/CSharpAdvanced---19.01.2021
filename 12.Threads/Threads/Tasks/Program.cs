using System;
using Tasks.Examples;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.Cancellation;

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
                case ExamplesEnumeration.Cancellation:
                    CancellationExample.ShowCancellation();
                    break;
            }

            Console.Read();
        }
    }
}