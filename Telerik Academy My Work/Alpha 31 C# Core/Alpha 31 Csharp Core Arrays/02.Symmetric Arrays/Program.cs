using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string[] nums = Console.ReadLine().Split(' ').ToArray();

            for (int j = 0; j < nums.Length / 2; j++)
            {
                if (nums.Length == 1)
                {
                    Console.WriteLine("Yes");
                    continue;
                }

                bool isSymmetric = true;
                for (int j = 0; j < nums.Length / 2; j++)
                {
                    string valueLeft = nums[j];
                    string valueRight = nums[nums.Length - 1 - j];

                    if (valueLeft != valueRight)
                    {
                        isSymmetric = false;
                        break;
                    }
                }

                if (isSymmetric)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}