using System;
using System.Collections.Generic;

namespace _04.Most_Frequent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int N = int.Parse(Console.ReadLine());
                list.Add(N);
            }

            Dictionary<int, int> kvp = new Dictionary<int, int>();
            foreach (var num in list)
            {
                if (!kvp.ContainsKey(num))
                {
                    kvp.Add(num, 1);
                }
                else
                {
                    kvp[num] += 1;
                }
            }

            var biggestCount = 0;
            int digit = '\0';

            foreach (var num in kvp)
            {
                if (num.Value > biggestCount)
                {
                    biggestCount = num.Value;
                    digit = num.Key;
                }
            }

            Console.WriteLine($"{digit} ({biggestCount} times)");
        }
    }
}
