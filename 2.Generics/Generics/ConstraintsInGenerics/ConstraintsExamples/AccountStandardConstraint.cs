using System;

namespace ConstraintsInGenerics.ConstraintsExamples
{
    public class Account<T> where T: struct
    {
        private T sum;

        public Account(T sum)
        {
            this.sum = sum;
        }

        public T GetSum()
        {
            return sum;
        }

        public void ShowSum()
        {
            Console.WriteLine($"Type: {typeof(T).ToString()}, Value: {sum}");
        }
    }
}
