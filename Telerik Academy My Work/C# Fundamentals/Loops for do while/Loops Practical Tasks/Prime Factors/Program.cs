using System;

namespace Prime_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    N /= i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
