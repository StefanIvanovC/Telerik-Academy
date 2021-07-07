using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            // The number of small bottles in the warehouse -integer number
            // The number of big bottles in the warehouse -integer number
            // The capacity of the truck -integer number

            int smallBottles = int.Parse(Console.ReadLine());
            int bigBottles = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (capacity - (bigBottles * 5) < 0)
            {
                bigBottles -= 1;
            }
            else
            {
                capacity -= bigBottles * 5;
            }

            if (capacity - smallBottles < 0)
            {
                smallBottles = capacity;
                capacity = 0;
            }
            else
            {
                capacity -= smallBottles;
            }

            if (capacity > 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(smallBottles);
            }

        }
    }
}
