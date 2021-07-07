using System;
using System.Linq;

namespace _05.Добри_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None).Select(int.Parse).ToArray();
            int A = input[0]; // 1
            int B = input[1]; // 10
            var counter = 0;
            bool isGood = false;

            for (int i = A; i <= B; i++)
            {
                if (i <= 10)
                {
                    counter++;
                    continue;
                }

                char[] arrOfChar = i.ToString().ToCharArray(); // 1 3 11
                var counteChr = 0;

                for (int j = 0; j < arrOfChar.Length; j++) // 2 loops
                {
                    var currentCh = int.Parse(arrOfChar[j].ToString()); // 1 

                    if (currentCh == 0)
                    {
                        counteChr++;
                        if (counteChr == arrOfChar.Length)
                        {
                            isGood = true;
                        }
                        continue;
                    }
                    if (i % currentCh == 0) // 13 % 1 == 0
                    {
                        counteChr++;
                        if (counteChr == arrOfChar.Length)
                        {
                            isGood = true;
                            continue;
                        }
                    }
                    
                }

                if (isGood == true)
                {
                    counter++;
                }
                isGood = false;
            }

            Console.WriteLine(counter);
        }
    }
}
