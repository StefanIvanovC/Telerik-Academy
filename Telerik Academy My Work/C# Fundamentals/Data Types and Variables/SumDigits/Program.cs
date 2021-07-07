using System;
using System.Linq;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int result = N.ToString().Sum(x => x - '0');

            Console.WriteLine(result);
        }
    }
}
