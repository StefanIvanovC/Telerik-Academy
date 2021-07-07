using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.pincode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None).ToList();
            List<string> reversed = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string num = "";
                num = Reverse(input[i]);
                reversed.Add(num);
            }

            int biggest = int.MinValue;
            foreach (var num in reversed)
            {
                int numberInt = int.Parse(num);
                if (biggest < numberInt)
                {
                    biggest = numberInt;
                }
            }

            Console.WriteLine(biggest);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
