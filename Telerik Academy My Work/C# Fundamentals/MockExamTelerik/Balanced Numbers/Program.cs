using System;

namespace Balanced_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int n = 0;


            while (true)
            {
                int storageN = N;
                int firstNum = N % 10;
                N /= 10;
                int secondNum = N % 10;
                N /= 10;
                int thirdNum = N % 10;


                int firstThird = firstNum + thirdNum;
                if (firstThird == secondNum)
                {
                    n += storageN;
                    
                }
                if (firstThird != secondNum)
                {
                    Console.WriteLine(n);
                    break;
                }
                N = int.Parse(Console.ReadLine());

            }
        }
    }
}
