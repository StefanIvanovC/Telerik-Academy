using System;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string parent1 = Console.ReadLine();
            string parent2 = Console.ReadLine();
            int split = int.Parse(Console.ReadLine());

            var children1 = "";
            var children2 = "";

            var switch1 = "";
            var switch2 = "";

            var counterFirstChild = 0;
            var counterSecondChild = 0;
            foreach (char digit in parent1)
            {
                if (counterFirstChild < split)
                {
                    children1 += digit;
                    counterFirstChild++;
                }
                else
                {
                    switch1 += digit;
                }
            }
            foreach (char digit in parent2)
            {
                if (counterSecondChild < split)
                {
                    children2 += digit;
                    counterSecondChild++;
                }
                else
                {
                    switch2 += digit;
                }
            }

            var firstChildResult = children1 + switch2;
            var secondChildResult = children2 + switch1;

            var sumFirstChild = 0;
            var sumSecondChild = 0;
            foreach (char c in firstChildResult)
            {
                if (c == '1')
                {
                    sumFirstChild++;
                }
                
            }
            foreach (var c in secondChildResult)
            {
                if (c == '1')
                {
                    sumFirstChild++;
                }
            }

            var ratioFirstChild = sumFirstChild / firstChildResult.Length;
            var ratioSecondChild = sumSecondChild / secondChildResult.Length;
            if (ratioSecondChild > ratioFirstChild)
            {
                if (ratioSecondChild < 0.5)
                {
                    char[] charArray = secondChildResult.ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine(secondChildResult);
                }
                else
                {
                    Console.WriteLine(secondChildResult);
                }
                return;
            }
            else
            {
                if (ratioFirstChild < 0.5)
                {
                    char[] charArray = firstChildResult.ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine(firstChildResult);
                    
                }
                else
                {
                    Console.WriteLine(firstChildResult);
                }
                return;
            }
        }
    }
}
