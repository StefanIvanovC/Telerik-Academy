using System;

namespace _1._Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
			int N = int.Parse(Console.ReadLine());
			int[,] matrix = new int[N, N];
			string wayToGo = "right";

			int row = 0;
			int col = 0;
			for (int i = 1; i <= (N * N); i++)
			{
				if ((wayToGo == "right") && (col > N - 1 || matrix[row, col] != 0))
				{
					wayToGo = "down";
					col--;
					row++;
				}
				if ((wayToGo == "down") && (row > N - 1 || matrix[row, col] != 0))
				{
					wayToGo = "left";
					row--;
					col--;
				}
				if ((wayToGo == "left") && (col < 0 || matrix[row, col] != 0))
				{
					wayToGo = "up";
					col++;
					row--;
				}
				if ((wayToGo == "up") && (row < 0 || matrix[row, col] != 0))
				{
					wayToGo = "right";
					row++;
					col++;
				}

				matrix[row, col] = i;

				if (wayToGo == "right") col++;
				if (wayToGo == "down") row++;
				if (wayToGo == "left") col--;
				if (wayToGo == "up") row--;
			}

			PrintMatrix(matrix, N);
    }
        private static void PrintMatrix(int[,] matrix, int N)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
			
        }
    }

}