using System;
using System.Linq;

namespace _03.Matrix_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var secondNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var row1 = firstNum[0]; // 2
            var col1 = firstNum[1]; // 3

            var row2 = secondNums[0]; // -4
            var col2 = secondNums[1]; // -2

         

        }
    }
}
