using System;
using ConstraintsInGenerics.ConstraintsExamples.HelpMaterial;

namespace ConstraintsInGenerics.ConstraintsExamples
{
    public class InterfaceAccount <T, R> where T: ISum <R>
    {
        private T sum;

        public InterfaceAccount(T sum)
        {
            this.sum = sum;
        }

        public void ShowData()
        {
            Console.WriteLine($"Sum type - {typeof(T).ToString()}, Qunatity type - {typeof(R).ToString()}, Quantity - {sum.Quantity}");
        }
    }
}
