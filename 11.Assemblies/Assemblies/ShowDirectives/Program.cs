using System;
using static ShowDirectives.ExampleClasses.StaticClassExample;
using nonStatic = ShowDirectives.ExampleClasses.NonStaticClassExample;

namespace ShowDirectives
{
    public class Class1
    {
        public void KindaMain()
        {
            new nonStatic().DoSmth();

            DoSmthStatic();
        }
    }
}
