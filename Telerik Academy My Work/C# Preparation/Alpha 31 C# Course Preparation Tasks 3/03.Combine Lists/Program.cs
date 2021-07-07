using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Combine_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            var secondNums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            
            int count = 0;
            if (firstNums.Length > secondNums.Length) count = firstNums.Length;
            else if (firstNums.Length < secondNums.Length) count = secondNums.Length;
            else count = firstNums.Length;

            List<int> combineNums = new List<int>(count * 2);

            for (int i = 0; i < count; i++)
            {
                int firstcurrent = firstNums[i];
                int secondCurrent = secondNums[i];
                combineNums.Add(firstcurrent);
                combineNums.Add(secondCurrent);
            }

            Console.WriteLine(string.Join(",",combineNums));
        }
    }
}
