using System;
using System.Collections.Generic;

namespace _01.Primes_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> primeNums = new List<int>();

            for (int i = 1; i < N + 1; i++)
            {
                if (IsPrime(i))
                {
                    primeNums.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", primeNums));
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1 ) return true;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
