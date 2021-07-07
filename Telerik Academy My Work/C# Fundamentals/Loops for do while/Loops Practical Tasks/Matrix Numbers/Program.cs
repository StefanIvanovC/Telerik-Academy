using System;

namespace Matrix_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    counter = col + row + 1;
                    
                    Console.Write(counter + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
