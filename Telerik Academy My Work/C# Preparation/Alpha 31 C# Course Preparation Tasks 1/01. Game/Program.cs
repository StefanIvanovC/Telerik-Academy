using System;

namespace _01._Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int biggestNum = 0;
            int firstNum = N % 10;
            N /= 10;
            int secondNum = N % 10;
            N /= 10;
            int thirdNum = N % 10;
            int firstCombination = firstNum + secondNum * thirdNum;
            int secondCombination = firstNum * secondNum + thirdNum;
            int thirdCombination = firstNum + secondNum + thirdNum;
            int fourthCombination = firstNum * secondNum * thirdNum;
            if (firstCombination > secondCombination && firstCombination > thirdCombination && firstCombination > fourthCombination)
            {
                biggestNum = firstCombination;
            }
            if (secondCombination > firstCombination && secondCombination > thirdCombination && secondCombination > fourthCombination)
            {
                biggestNum = secondCombination;
            }
            if (thirdCombination > firstCombination && thirdCombination > secondCombination && thirdCombination > fourthCombination)
            {
                biggestNum = thirdCombination;
            }
            if (fourthCombination >= firstCombination && fourthCombination >= secondCombination && fourthCombination >= thirdCombination)
            {
                biggestNum = fourthCombination;
            }
            if (secondCombination == thirdCombination)
            {
                biggestNum = secondCombination;
            }

            Console.WriteLine(biggestNum);
        }
    }
}
