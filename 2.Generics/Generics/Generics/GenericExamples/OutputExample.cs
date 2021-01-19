using System;

namespace Generics.GenericExamples
{
    public class OutputExample
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
        
        public void ShowFirstMethod()
        {
            Console.WriteLine("This is first variable: " + First);
        }

        public void ShowSecondMethod()
        {
            Console.WriteLine("This is first variable: {0}, this is second: {1}, this is third: {2}", First, Second, Third);
        }

        public void ShowThirdMethod()
        {
            Console.WriteLine($"This is first variable: {First}, \r this is second: {Second}, this is third {Third}");
        }
    }
}
