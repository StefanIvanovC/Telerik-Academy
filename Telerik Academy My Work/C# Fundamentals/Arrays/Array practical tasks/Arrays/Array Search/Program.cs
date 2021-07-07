using System;

namespace Array_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',');

            string missingNums = "";

            for (int currentNum = 1; currentNum <= input.Length; currentNum++)
            {
                bool isFound = false;
                foreach (var item in input)
                {
                    if (currentNum == int.Parse(item))
                    {
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    if (missingNums.Length > 0)
                    {
                        missingNums += ',';
                    }
                    missingNums += currentNum;
                }
            }

            Console.WriteLine(missingNums);
        }
    }
}
