using System;
using System.Linq;

namespace _07.Zig_Zag
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong[] nM = Console.ReadLine().Split().Select(ulong.Parse).ToArray();
            ulong N = nM[0];
            ulong M = nM[1];
            ulong[,] matrix = new ulong[N, M];
            ulong counter = 1;
            ulong sum = 0;
            for (ulong row = 0; row < N ; row++)
            {
                if (row != 0) counter = matrix[row - 1, 1];

                for (ulong col = 0; col < M; col++)
                {
                    matrix[row, col] = counter;
                    counter += 3;

                    if (row == 0 || row == N -1) // first row and last row
                    {
                        if ((N - 1) % 2 == 1)
                        {
                            if (col % 2 == 1)
                            {
                                sum += matrix[row, col];
                            }
                        }
                        else if (col % 2 == 0)
                        {
                            sum += matrix[row, col];
                        }
                    }
                    else if (row % 2 == 1 && col % 2 == 1) // if row is odd and coll is odd
                    {
                        if (col == M - 1)
                        {
                            sum += matrix[row, col]; 
                        }
                        else
                        {
                            sum += 2 * matrix[row, col];
                        }
                    }
                    else if (row % 2 == 0 && col % 2 == 0) // if row is even
                    {
                        if (col == 0 )
                        {
                            sum +=  matrix[row, col];
                        }
                        else
                        {
                            sum += 2 * matrix[row, col];
                        }
                    }
                }

               
            }
            Console.WriteLine(sum);
        }
    }
}
