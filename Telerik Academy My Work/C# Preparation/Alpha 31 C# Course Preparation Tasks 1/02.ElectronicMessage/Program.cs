using System;
using System.Collections.Generic;

namespace _02.ElectronicMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageInput = Console.ReadLine();
            int currentCounter = 0;
            int biggestCount = 0;
            //char last = '\0';
            //char lastDifferent = '\0';

            foreach (char ch in messageInput)
            {
                if (!char.IsWhiteSpace(ch) && !char.IsLetterOrDigit(ch) && ch != '.')
                {
                    currentCounter++;

                   //if (last == ch)
                   //{
                   //    if (lastDifferent == ch)
                   //    {
                   //        currentCounter = 0;
                   //    }
                   //    currentCounter++;
                   //    biggestCount = currentCounter;
                   //}
                   //last = ch;
                   //lastDifferent = ch;
                   //continue;
                }
                else
                {
                    if (biggestCount < currentCounter)
                    {
                        biggestCount = currentCounter;
                        currentCounter = 0;
                        continue;
                    }

                    currentCounter = 0;
                }
            }

                Console.WriteLine(biggestCount);
           
        }
    }
}
