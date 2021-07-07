using System;

namespace Find_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }

            double avarage = sum / n;

            Console.WriteLine($"{avarage:f2}");
        }
    }
}
