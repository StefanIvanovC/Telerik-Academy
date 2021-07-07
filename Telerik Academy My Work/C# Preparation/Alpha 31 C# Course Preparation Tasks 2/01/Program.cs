using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int rowsCount = 2 * N - 1;
            int rowLoops = 0;

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (rowLoops == col )
                    {
                        Console.Write("*");
                    }
                    
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
                if (N - 1 > row) rowLoops++;
                else rowLoops--;
            }
        }
    }
}
