using System;

namespace Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sumDeposited = decimal.Parse(Console.ReadLine());

            var firstYear = sumDeposited + (sumDeposited * 0.05m);
            var secondYear = firstYear + (firstYear * 0.05m);
            var thirdYear = secondYear + (secondYear * 0.05m);

            Console.WriteLine($"{firstYear:f2}");
            Console.WriteLine($"{secondYear:f2}");
            Console.WriteLine($"{thirdYear:f2}");
        }
    }
}
