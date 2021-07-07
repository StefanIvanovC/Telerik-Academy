using System;

namespace Sort_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());


            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.Write($"{firstNum} ");
                if (secondNum > thirdNum)
                {
                    Console.Write($"{secondNum} {thirdNum}");
                }
                else
                {
                    Console.Write($"{thirdNum} {secondNum}");
                }
            }

            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                Console.Write($"{secondNum} ");
                if (firstNum > thirdNum)
                {
                    Console.Write($"{firstNum} {thirdNum}");
                }
                else
                {
                    Console.Write($"{thirdNum} {firstNum}");
                }
            }

            else // (thirdNum > firstNum && thirdNum > secondNum)
            {
                Console.Write($"{thirdNum} ");
                if (firstNum > secondNum)
                {
                    Console.Write($"{firstNum} {secondNum}");
                }
                else
                {
                    Console.Write($"{secondNum} {firstNum}");
                }
            }
        }
    }
}
