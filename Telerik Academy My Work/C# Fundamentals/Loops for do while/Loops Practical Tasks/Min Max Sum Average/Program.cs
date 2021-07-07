using System;

namespace Min_Max_Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal min = decimal.MaxValue;
            decimal max = decimal.MinValue;
            decimal sum = 0;
            decimal avg = 0;

            for (int i = 0; i < n ; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            avg = sum / n;
            Console.WriteLine($"min={min:f2}");
            Console.WriteLine($"max={max:f2}");
            Console.WriteLine($"sum={sum:f2}");
            Console.WriteLine($"avg={avg:f2}");
        }
    }
}
