using System;
using System.Collections.Generic;
using System.Linq;

namespace Convert_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] celsius = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var celsiusDegrees in celsius)
            {
                double doubleCelsius = Convert.ToDouble(celsiusDegrees);
                double doubleResult = (doubleCelsius * 1.8) + 32;
                Console.WriteLine(Math.Round(doubleResult));
            }
        }
    }
}
