using System;

namespace Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = 1; i <= N; i++) // 5 loop
            {
                int x = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (even == 0)
                    {
                        even += x;
                    }
                    else
                    {
                        even *= x;
                    }
                    
                }

                if (i % 2 == 1)
                {
                    if (odd == 0)
                    {
                        odd += x;
                    }
                    else
                    {
                        odd *= x;   
                    }
                }
            }

            if (even == odd)
            {
                Console.WriteLine($"yes {even}");
            }
            else
            {
                Console.WriteLine($"no {odd} {even}");
            }
        }
    }
}
