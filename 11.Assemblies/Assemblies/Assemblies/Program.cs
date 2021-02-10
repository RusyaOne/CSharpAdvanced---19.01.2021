using Assemblies.Examples;
using System;

namespace Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.GetConstructors;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.ShowDefine:
                    BasicDirectives.ShowDefine();
                    break;
                case ExamplesEnumeration.ShowDebug:
                    BasicDirectives.ShowDebug();
                    break;
                case ExamplesEnumeration.GetType:
                    GetTypeExamples.ShowGetType();
                    break;
                case ExamplesEnumeration.GetAssembly:
                    GetAssemblyExample.ShowGetAssembly();
                    break;
                case ExamplesEnumeration.GetConstructors:
                    GetConstuctorExample.ShowGetConstructor();
                    break;
            }



            Console.Read();
        }
    }
}
