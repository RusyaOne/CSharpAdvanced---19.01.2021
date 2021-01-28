using System;
using System.Collections.Generic;
using System.Text;

namespace StaticVsNotStatic
{
    class ExampleStaticMethods
    {
        public void NosStatic()
        {
            Console.WriteLine("This is not static method");
        }

        public static void Static()
        {
            Console.WriteLine("This is static method");
        }
    }
}
