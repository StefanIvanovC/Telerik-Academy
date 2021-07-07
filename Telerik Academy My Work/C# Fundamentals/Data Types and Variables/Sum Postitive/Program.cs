using System;

namespace Sum_Postitive
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = n * (n + 1) / 2;

            Console.WriteLine(sum);
        }
    }
}
