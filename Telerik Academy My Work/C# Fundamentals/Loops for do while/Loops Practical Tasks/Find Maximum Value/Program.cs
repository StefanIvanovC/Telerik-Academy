using System;

namespace Find_Maximum_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;

            for (int i = 0; i < N; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (maxNum < currentNumber)
                {
                    maxNum = currentNumber;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
