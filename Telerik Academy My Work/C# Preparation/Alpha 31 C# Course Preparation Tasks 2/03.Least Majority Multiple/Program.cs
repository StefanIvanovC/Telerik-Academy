using System;

namespace _03.Least_Majority_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i < 1000000; i++)
            {
                counter = 0;
                if (i % a == 0) counter++;
                if (i % b == 0) counter++;
                if (i % c == 0) counter++;
                if (i % d == 0) counter++;
                if (i % e == 0) counter++;
                if (counter >= 3)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
