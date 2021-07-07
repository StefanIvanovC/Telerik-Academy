using System;

namespace Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);


        }
    }
}
