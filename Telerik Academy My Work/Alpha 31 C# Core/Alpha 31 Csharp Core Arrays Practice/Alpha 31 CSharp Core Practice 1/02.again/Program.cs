using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.again
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = sizes[0];
            var b = sizes[1];
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<int>();

            var plus = 0;
            if (a == b)
            {
                for (int i = 0; i < a; i++)
                {
                    var firstCurrent = firstArr[i];
                    var secondCurrent = secondArr[i];

                    var sum = firstCurrent + secondCurrent + plus;

                    if (sum == 10)
                    {
                        list.Add(0);
                        plus = 1;
                    }
                    else if (sum > 10)
                    {
                        list.Add(sum % 10);
                        plus = 1;
                    }
                    else if (sum <= 9)
                    {
                        list.Add(sum);
                        plus = 0;
                    }
                   

                }
            }

            if (a < b)
            {
                
                for (int i = 0; i < a; i++)
                {
                    var firstCurrent = firstArr[i];
                    var secondCurrent = secondArr[i];

                    var sum = firstCurrent + secondCurrent + plus;

                    if (sum == 10)
                    {
                        list.Add(0);
                        plus = 1;
                    }
                    else if (sum > 10)
                    {
                        list.Add(sum % 10);
                        plus = 1;
                    }
                    else if (sum <= 9)
                    {
                        list.Add(sum);
                        plus = 0;
                    }
                }
                for (int i = a; i < b; i++)
                {
                    list.Add(secondArr[i]);
                }
            }

            if (a > b)
            {
                
                for (int i = 0; i < b; i++)
                {
                    var firstCurrent = firstArr[i];
                    var secondCurrent = secondArr[i];

                    var sum = firstCurrent + secondCurrent + plus;

                    if (sum == 10)
                    {
                        list.Add(0);
                        plus = 1;
                    }
                    else if (sum > 10)
                    {
                        list.Add(sum % 10);
                        plus = 1;
                    }
                    else if (sum <= 9)
                    {
                        list.Add(sum);
                        plus = 0;
                    }
                }
                for (int i = b; i < a; i++)
                {
                    list.Add(firstArr[i]);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
