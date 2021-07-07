using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToList();
            List<int> numsAwayFromZero = new List<int>();
            int counter = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] != 0)
                {
                    numsAwayFromZero.Add(nums[i]);
                }
                else
                {
                    counter++;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                numsAwayFromZero.Add(0);
            }

            Console.WriteLine(string.Join(",", numsAwayFromZero));
        }
    }
}
