using System;

namespace Biggest_of_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = decimal.Parse(Console.ReadLine());
            var secondNum = decimal.Parse(Console.ReadLine());
            var thirdNum = decimal.Parse(Console.ReadLine());

            var biggest = firstNum;

            if (firstNum > secondNum && firstNum > thirdNum)
            {
                biggest = firstNum;
            }
            if (secondNum > firstNum && secondNum > thirdNum)
            {
                biggest = secondNum;
            }
            if (thirdNum > firstNum && thirdNum > secondNum)
            {
                biggest = thirdNum;
            }

            Console.WriteLine(biggest);
        }
    }
}
