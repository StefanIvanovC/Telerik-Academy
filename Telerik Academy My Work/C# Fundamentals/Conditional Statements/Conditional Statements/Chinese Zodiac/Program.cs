using System;

namespace Chinese_Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int startFromYear = year % 12; // 2000 % 12 = 8 Dragon - Console.WriteLine(2000 % 12);
            switch (startFromYear)
            {
                case 0:
                    Console.WriteLine("Monkey");
                    break;
                case 1:
                    Console.WriteLine("Rooster");
                    break;
                case 2:
                    Console.WriteLine("Dog");
                    break;
                case 3:
                    Console.WriteLine("Pig");
                    break;
                case 4:
                    Console.WriteLine("Rat");
                    break;
                case 5:
                    Console.WriteLine("Ox");
                    break;
                case 6:
                    Console.WriteLine("Tiger");
                    break;
                case 7:
                    Console.WriteLine("Hare");
                    break;
                case 8:
                    Console.WriteLine("Dragon");
                    break;
                case 9:
                    Console.WriteLine("Snake");
                    break;
                case 10:
                    Console.WriteLine("Horse");
                    break;
                case 11:
                    Console.WriteLine("Sheep");
                    break;
            }
        }
    }
}
