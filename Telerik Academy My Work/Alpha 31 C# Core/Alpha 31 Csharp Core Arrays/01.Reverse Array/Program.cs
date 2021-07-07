using System;
using System.Linq;

namespace _01.Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] reversedArr = new int[input.Length];
            int counter = 0;

            for (int i = input.Length; i > 0; i--)
            {
                int currentNummber = input[i - 1];
                reversedArr[counter] = currentNummber;
                counter++;
            }

            Console.WriteLine(string.Join(", ", reversedArr));
        }
    }
}
