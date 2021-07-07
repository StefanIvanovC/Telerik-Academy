using System;

namespace BiggestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = decimal.Parse(Console.ReadLine());
            var secondNum = decimal.Parse(Console.ReadLine());
            var thirdNum = decimal.Parse(Console.ReadLine());
            var forthNum = decimal.Parse(Console.ReadLine());
            var fifthNum = decimal.Parse(Console.ReadLine());

            var biggest = firstNum;

            if (firstNum > secondNum && firstNum > thirdNum && firstNum > forthNum && firstNum > fifthNum)
            {
                biggest = firstNum;
            }
            if (secondNum > firstNum && secondNum > thirdNum && secondNum > forthNum && secondNum > fifthNum)
            {
                biggest = secondNum;
            }
            if (thirdNum > firstNum && thirdNum > secondNum && thirdNum > forthNum && thirdNum > fifthNum)
            {
                biggest = thirdNum;
            }
            if (forthNum > firstNum && forthNum > secondNum && forthNum > thirdNum && forthNum > fifthNum)
            {
                biggest = forthNum;
            }
            if (fifthNum > firstNum && fifthNum > secondNum && fifthNum > thirdNum && fifthNum > forthNum)
            {
                biggest = fifthNum;
            }

            Console.WriteLine(biggest);
        }
    }
}
