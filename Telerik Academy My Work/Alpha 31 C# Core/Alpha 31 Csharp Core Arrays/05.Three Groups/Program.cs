using System;
using System.Linq;

namespace _05.Three_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            int counterZeroReminder = 0;
            int counterOneReminder = 0;
            int counterTwoReminder = 0;
            int lenght1 = 0;
            int lenght2 = 0;
            int lenght3 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    lenght1++;
                    continue;
                }
                else if (nums[i] % 3 == 1)
                {
                    lenght2++;
                    continue;
                }
                else
                {
                    lenght3++;
                    continue;
                }
            }

            int[] numsWithoutReminder = new int[lenght1];
            int[] numsWithReminderOne = new int[lenght2];
            int[] numsWithReminderTwo = new int[lenght3];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    numsWithoutReminder[counterZeroReminder] = nums[i];
                    counterZeroReminder++;
                    continue;
                }
                else if (nums[i] % 3 == 1)
                {
                    numsWithReminderOne[counterOneReminder] = nums[i];
                    counterOneReminder++;
                    continue;
                }
                else
                {
                    numsWithReminderTwo[counterTwoReminder] = nums[i];
                    counterTwoReminder++;
                    continue;
                }
            }

            if (numsWithoutReminder.Length > 0)
            {
                Console.WriteLine(string.Join(" ", numsWithoutReminder));
            }
            if (numsWithReminderOne.Length > 0)
            {
                Console.WriteLine(string.Join(" ", numsWithReminderOne));
            }
            if (numsWithReminderTwo.Length > 0)
            {
                Console.WriteLine(string.Join(" ", numsWithReminderTwo));
            }
            
        }

    }
}
