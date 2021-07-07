using System;
using System.Linq;

namespace _04.sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None).Select(int.Parse).ToList();
            int first = input[0];
            int second = input[1];
            int third = input[2];
            int fourth = input[3];

            if (first > second && second > third && third > fourth)
            {
                Console.WriteLine("Descending");
            }
            else if (first < second && second < third && third < fourth)
            {
                Console.WriteLine("Ascending");
            }
            else
            {
                Console.WriteLine("Mixed");
            }

        }
    }
}
