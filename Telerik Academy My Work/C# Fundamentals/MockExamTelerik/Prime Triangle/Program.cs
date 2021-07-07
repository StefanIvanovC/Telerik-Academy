using System;
using System.Collections.Generic;

namespace Prime_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= N; i++)
            {
                if (IsPrime(i))
                {
                    Print(i);
                }
            }
        }

        static public void Print(int num)
        {
            Console.WriteLine();
            for (int i = 1; i <= num; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(0);
                }
            }
        }

        public static bool IsPrime(int num)
        {
            if (num == 1) return true;
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
