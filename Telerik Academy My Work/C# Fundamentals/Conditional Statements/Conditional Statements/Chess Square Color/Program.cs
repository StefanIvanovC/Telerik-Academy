using System;

namespace Chess_Square_Color
{
    class Program
    {
        static void Main(string[] args)
        {
            char label = char.Parse(Console.ReadLine());
            int rank = int.Parse(Console.ReadLine());

            if (label == 'a' || label == 'c' || label == 'e' || label == 'g')
            {
                if (rank % 2 == 0)
                {
                    Console.WriteLine("light");
                }
                else if (rank % 2 == 1)
                {
                    Console.WriteLine("dark");
                }
            }
            else if (label == 'b' || label == 'd' || label == 'f' || label == 'h')
            {
                if (rank % 2 == 0)
                {
                    Console.WriteLine("dark");
                }
                else if (rank % 2 == 1)
                {
                    Console.WriteLine("light");
                }
            }
        }
    }
}
