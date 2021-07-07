using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Longest_Increasing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int counter = 0;
            int currentCounter = 0;
            int current = int.Parse(Console.ReadLine()); 
            var last = current;
            for (int i = 1; i < N ; i++)
            {
                current = int.Parse(Console.ReadLine());

                if (current > last)
                {
                    currentCounter++;
                    if (currentCounter > counter)
                    {
                        counter = currentCounter;
                    }
                    last = current;
                }
                else if (current == last)
                {
                    last = current;
                }
                else
                {
                    currentCounter = 0;
                    last = current;
                    
                }
            }
            if (counter > 0)
            {
                counter++;
            }
            else
            
            {
                counter = 1;
            }
            Console.WriteLine(counter);
        }

    }
}
