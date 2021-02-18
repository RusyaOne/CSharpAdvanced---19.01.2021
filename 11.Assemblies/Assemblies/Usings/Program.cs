using System;
using static Usings.ExampleClasses.StaticClassExample;
using NonStatic = Usings.ExampleClasses.NonStaticClassExample;

namespace Usings
{
    public class Class1
    {
        public void KindaMain()
        {
            new NonStatic().DoSmth();

            DoSmthStatic();
        }
    }
}
