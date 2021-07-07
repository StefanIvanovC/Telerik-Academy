using System;

namespace Dog_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            int humanYears = int.Parse(Console.ReadLine());
            int dogYears = 0;

            if (humanYears <= 2)
            {
                dogYears = humanYears * 10;
            }
            else if (humanYears >= 3)
            {
                dogYears = 20 + (humanYears - 2) * 4;
            }

            Console.WriteLine(dogYears);
        }
    }
}
