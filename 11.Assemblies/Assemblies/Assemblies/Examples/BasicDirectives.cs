#define example

using System;
using System.Collections.Generic;
using System.Text;


namespace Assemblies.Examples
{
    public static class BasicDirectives
    {
        public static void ShowDefine()
        {

#if example
            Console.WriteLine("Example directive is defined");
#else
            Console.WriteLine("Example directive is not defined");
#endif
        }

        public static void ShowDebug()
        {

#if DEBUG
            Console.WriteLine("App running in debug mode");
#else
            Console.WriteLine("App running in release mode");
#endif
        }
    }
}
