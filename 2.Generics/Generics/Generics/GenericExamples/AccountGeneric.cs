using System;

namespace Generics.Examples
{
    public class Account <T>
    {
        private T sum;

        public Account (T sum)
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
