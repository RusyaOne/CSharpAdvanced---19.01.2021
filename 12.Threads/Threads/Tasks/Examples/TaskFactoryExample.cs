using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Threads.Services.ThreadsService;

namespace Tasks.Examples
{
    public static class TaskFactoryExample
    {
        public static void ShowTaskFactory()
        {
            //Task is already started, no need to invoke thread.Start()
            Task task = Task.Factory.StartNew(WriteThreadNumber);
            
            //TaskFactory factory = new TaskFactory();
            //Task task = factory.StartNew(MyTask);
        }
    }
}
