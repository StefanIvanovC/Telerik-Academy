using System;

namespace TelerikFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int halfBottleCount = int.Parse(Console.ReadLine());
            int oneBottleCount = int.Parse(Console.ReadLine());

            double halfBottleDeposit = 0.10;
            double oneBottleDeposit = 0.25;

            var halfResult = Convert.ToDouble(halfBottleCount) * halfBottleDeposit;
            var oneResult = Convert.ToDouble(oneBottleCount) * oneBottleDeposit;

            var result = halfResult + oneResult;

            Console.WriteLine($"{result:f2}");
        }
    }
}
