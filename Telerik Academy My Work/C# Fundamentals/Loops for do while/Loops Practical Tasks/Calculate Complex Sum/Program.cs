using System;

namespace Calculate_Complex_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double S = 1;

            int factoriel = 1;

            for (int i = 1; i <= N; i++)
            {
                factoriel = factoriel * i;
                S = S + factoriel / Math.Pow(x, i); // S = 1 + 1!/x
            }

            Console.WriteLine($"{S:f5}");
        }
    }
}
