using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexStart = int.Parse(Console.ReadLine()); // 0
            var numbersArr = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); // 10 20 30
            var command = Console.ReadLine().Split(" ");
            

            var forwardCount = 0;
            var backCount = 0;
            var currentIndex = indexStart;
            while (command[0] != "exit")
            {
                var times = int.Parse(command[0]); // 
                var step = command[1];  // "forward"
                var index = int.Parse(command[3]); // 1
                

                for (int i = indexStart; i < times; i++)
                {
                    var indexForStep = currentIndex + index;
                    var currentNum = numbersArr[indexForStep];
                    if (step == "forward")
                    {
                        if (currentNum > )
                        {

                        }
                        forwardCount += currentNum;
                    }
                }



            }

        }
    }
}
