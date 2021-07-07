using System;
using System.Collections.Generic;
using System.Linq;

namespace Below_and_Above_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> belowAvr = new List<int>();
            List<int> aboveAvr = new List<int>();
            var avr = nums.Average();

            for (int i = 0; i < nums.Count; i++)
            {
                if (avr == nums[i])
                {
                    continue;
                }
                if (nums[i] < avr)
                {
                    belowAvr.Add(nums[i]);
                }
                else
                {
                    aboveAvr.Add(nums[i]);
                }
            }

            Console.WriteLine($"avg: {avr:f2}");
            Console.WriteLine($"below: {string.Join(",", belowAvr)}");
            Console.WriteLine($"above: {string.Join(",", aboveAvr)}");
        }
    }
}
