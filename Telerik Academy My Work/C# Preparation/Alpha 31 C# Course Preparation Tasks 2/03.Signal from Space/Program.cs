using System;
using System.Collections.Generic;

namespace _03.Signal_from_Space
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var charArr = input.ToCharArray();
            List<char> charResult = new List<char>();
            
            char temp = '\0';
            
            for (int i = 1; i < charArr.Length; i++)
            {
                if (i == 1)
                {
                    char firstChar = charArr[0];
                    charResult.Add(firstChar);
                    temp = firstChar;
                }
                
                char current = charArr[i];
                temp = charArr[i - 1];

                if (current != temp)
                {
                    charResult.Add(current);
                }
            }

            foreach (var ch in charResult)
            {
                Console.Write(ch);
            }
        }
    }
}
