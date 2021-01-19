using System;

namespace Generics.Examples
{
    class Account <T, R>
    {
        private T id;
        private R sum;

        public Account(T id, R sum)
        {
            this.id = id;
            this.sum = sum;
        }

        public void ShowData()
        {
            Console.WriteLine($"id: Type - {typeof(T).ToString()}, Value - {id}");
            Console.WriteLine($"sum: Type - {typeof(R).ToString()}, Value - {sum}");
        }

        public (T, R) GetData()
        {
            return (id, sum);
        }
    }
}
