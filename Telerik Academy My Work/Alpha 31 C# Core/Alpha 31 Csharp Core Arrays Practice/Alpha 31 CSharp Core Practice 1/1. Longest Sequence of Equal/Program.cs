using System;

namespace _1._Longest_Sequence_of_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int biggestSequence = 0;
            int counter = 0;
            int lastDigit = 0;

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    counter++;
                    lastDigit = num;
                    if (biggestSequence < counter)
                    {
                        biggestSequence = counter;
                    }
                    continue;
                }
                if (lastDigit == num)
                {
                    counter++;
                    if (biggestSequence < counter)
                    {
                        biggestSequence = counter;
                    }
                    lastDigit = num;
                }
                else
                {
                    counter = 1;
                    lastDigit = num;
                }
            }

            Console.WriteLine(biggestSequence);
          
        }
    }
}
