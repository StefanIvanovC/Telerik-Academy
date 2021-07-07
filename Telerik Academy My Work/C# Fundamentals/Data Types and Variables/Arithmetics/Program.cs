using System;

namespace Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            double substracted = a - b;
            double product = a * b;
            double remainder = a % b;
            double power = Math.Pow(a,b);

            Console.WriteLine(sum);
            Console.WriteLine(substracted);
            Console.WriteLine(product);
            Console.WriteLine(remainder);
            Console.WriteLine(power);
        }
    }
}
