using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Largest_Three_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            //int[] nums = new int[N];
            //
            //for (int i = 0; i < N; i++)
            //{
            //    nums[i] = int.Parse(Console.ReadLine());
            //}
            //
            //Array.Sort(nums);
            //Array.Reverse(nums);
            //int first = nums[0];
            //int second = nums[1];
            //int third = nums[2];
            //
            //Console.WriteLine($"{first}, {second} and {third}");

            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > first)
                {
                    third = second;
                    second = first;
                    first = current;
                }
                else if (current > second)
                {
                    third = second;
                    second = current;
                }
                else
                {
                    third = current;   
                }

            }

            Console.WriteLine($"{first}, {second} and {third}");

        }
    }
}
