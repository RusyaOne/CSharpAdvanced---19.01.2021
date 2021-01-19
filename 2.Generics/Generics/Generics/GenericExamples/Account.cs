using System;

namespace Generics.Examples
{
    public class Account
    {
        private int sum;

        public Account(int sum)
        {
            this.sum = sum;
        }

        public int GetSum()
        {
            return sum;
        }

        public void ShowSum()
        {
            Console.WriteLine($"Type: {typeof(int).ToString()}, Value: {sum}");
        }
    }
}
