using System;
using System.Linq;

namespace Is_a_List_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

                bool isSorted = true;
                int previous = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    int current = nums[j];

                    if (j == 0)
                    {
                        continue;
                    }
                    else
                    {
                        previous = nums[j - 1];
                    }

                    if (previous <= current)
                    {
                        isSorted = true;
                    }
                    else
                    {
                        isSorted = false;
                        break;
                    }
                }

                if (isSorted)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                
            }
        }
    }
}
