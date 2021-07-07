using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int first = int.Parse(Console.ReadLine()); // 42
        List<string> sumNumResult = new List<string>();
        List<string> multSumResult = new List<string>();
        for (int i = 0; i < N - 1; i++)
        {

            int second = int.Parse(Console.ReadLine()); //35
            int secondRound = second;
            int secondNum = first % 10; // 2
            first /= 10;
            int firstNum = first % 10; // 4

            int forthNum = second % 10;// 5
            second /= 10;
            int thirdNum = second % 10;//3

            int sum = secondNum + thirdNum;// 2 + 3
            if (sum >= 10)
            {
                sum = sum % 10;
            }
            string sumNum = $"{secondNum}{thirdNum}";
            string mult = $"{firstNum}{sum}{forthNum}";
            
            sumNumResult.Add(sumNum);
            //Console.WriteLine(sumNum);
            multSumResult.Add(mult);
            //Console.WriteLine(mult);

            first = secondRound;
        }

        Console.WriteLine(string.Join(" ", sumNumResult));
        Console.WriteLine(string.Join(" ", multSumResult));

    }
}