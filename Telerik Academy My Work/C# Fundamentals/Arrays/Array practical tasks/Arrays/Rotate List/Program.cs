using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotate_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(',').ToArray();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var temp = arr[0];

                for (var j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
