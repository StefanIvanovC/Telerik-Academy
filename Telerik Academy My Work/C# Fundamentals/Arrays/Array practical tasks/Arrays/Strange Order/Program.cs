using System;
using System.Collections.Generic;
using System.Linq;

namespace Strange_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> negativeNums = new List<int>();
            List<int> zeros = new List<int>();
            List<int> positveNums = new List<int>();
            List<int> strangeOrdered = new List<int>();
            
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    negativeNums.Add(nums[i]);
                }
                else if (nums[i] == 0)
                {
                    zeros.Add(nums[i]);
                }
                else
                {
                    positveNums.Add(nums[i]);
                }
            }

            foreach (var num in negativeNums)
            {
                strangeOrdered.Add(num);
            }
            foreach (var num in zeros)
            {
                strangeOrdered.Add(num);
            }
            foreach (var num in positveNums)
            {
                strangeOrdered.Add(num);
            }

            Console.Write(string.Join(",", strangeOrdered)); //Working but not in Telerik Judje
        }
    }
}
