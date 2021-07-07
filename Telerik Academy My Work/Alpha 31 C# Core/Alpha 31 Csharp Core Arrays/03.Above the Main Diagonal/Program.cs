using System;

namespace _03.Above_the_Main_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            ulong[,] matrix = new ulong[size, size];
            ulong counter = 1;
            ulong sum = 0;
            for (int row = 0; row < size; row++)
            {
                if (row != 0) counter = matrix[row - 1, 1];

                for (int col = 0; col < size; col++)
                {

                    matrix[row, col] = counter;
                    counter *= 2;
                    if (row >= 0 && col <= row)
                    {
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
