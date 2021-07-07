using System;

namespace _04.Longest_Block_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char prevChar = inputString[0];
            string currentBlock = string.Empty;
            string longestBlock = string.Empty;

            currentBlock += prevChar;
            longestBlock = currentBlock;

            for (int i = 1; i < inputString.Length; i++)
            {
                char currChar = inputString[i];
                if (currChar == prevChar)
                {
                    currentBlock += currChar;
                    if (currentBlock.Length > longestBlock.Length)
                    {
                        longestBlock = currentBlock;
                    }
                }
                else
                {
                    currentBlock = "";
                    prevChar = currChar;
                    currentBlock += prevChar;
                }
            }
            Console.WriteLine(longestBlock);
        }
    }
}
