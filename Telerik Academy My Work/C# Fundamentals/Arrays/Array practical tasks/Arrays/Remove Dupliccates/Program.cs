using System;
using System.Collections.Generic;

namespace Remove_Dupliccates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var unique = new HashSet<string>(input.Split(','));

            Console.WriteLine(string.Join(",", unique)); 


        }
    }
}
