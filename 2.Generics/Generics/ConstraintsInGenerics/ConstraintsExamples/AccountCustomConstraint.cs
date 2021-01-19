using ConstraintsInGenerics.ConstraintsExamples.HelpMaterial;
using System;

namespace ConstraintsInGenerics.ConstraintsExamples
{
    public class CustomAccount <T> where T: CustomSum
    {
        private T sum = default(T);

        public CustomAccount (T customSum)
        {
            sum = customSum;
        }

        public void ShowSum()
        {
            Console.WriteLine($"Sum: Type - {typeof(T).ToString()}, Value: {sum.Quantity}");
        }
    }
}
