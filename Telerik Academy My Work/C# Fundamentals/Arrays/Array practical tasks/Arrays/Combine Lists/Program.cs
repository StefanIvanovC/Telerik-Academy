using System;
using System.Collections.Generic;
using System.Linq;

namespace Combine_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            List<int> combined = new List<int>();

            for (int i = 0; i < first.Length; i++)
            {
                int firstArrayNum = first[i];
                int secondArrayNum = second[i];

                combined.Add(firstArrayNum);
                combined.Add(secondArrayNum);
            }

            Console.WriteLine(string.Join(",", combined));
            
        }
    }
}
