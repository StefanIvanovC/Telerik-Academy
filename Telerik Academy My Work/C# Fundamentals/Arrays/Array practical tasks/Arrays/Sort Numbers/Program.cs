using System;
using System.Linq;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToList();

            input.Sort();
            input.Reverse();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
