using System;

namespace Calculate_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cost = decimal.Parse(Console.ReadLine());
            decimal paid = decimal.Parse(Console.ReadLine());

            decimal money = paid - cost;

            decimal lev = 0m;
            decimal fifty = 0m;
            decimal twenty = 0m;
            decimal ten = 0m;
            decimal five = 0m;
            decimal two = 0m;
            decimal one = 0m;

            while (money > 0)
            {
                if (money >= 1)
                {
                    lev += 1m;
                    money -= 1m;
                    continue;
                    
                }
                if (money >= 0.50m)
                {
                    fifty += 1;
                    money -= 0.50m;
                    continue;
                    
                }
                if (money >= 0.20m)
                {
                    twenty += 1m;
                    money -= 0.20m;
                    continue;
                }
                if (money >= 0.10m)
                {
                    ten += 1m;
                    money -= 0.10m;
                    continue;
                    
                }
                if (money >= 0.05m)
                {
                    five += 1m;
                    money -= 0.05m;
                    continue;
                }
                if (money >= 0.02m)
                {
                    two += 1m;
                    money -= 0.02m;
                    continue;
                }
                if (money >= 0.01m)
                {
                    one += 1m;
                    money -= 0.01m;
                    continue;
                }

                if (money <= 0)
                {
                    break;
                }
            }

            if (lev > 0)
            {
                Console.WriteLine($"{lev} x 1 lev");
            }
            if (fifty > 0)
            {
                Console.WriteLine($"{fifty} x 50 stotinki");
            }
            if (twenty > 0)
            {
                Console.WriteLine($"{twenty} x 20 stotinki");
            }
            if (ten > 0)
            {
                Console.WriteLine($"{ten} x 10 stotinki");
            }
            if (five > 0)
            {
                Console.WriteLine($"{five} x 5 stotinki");
            }
            if (two > 0)
            {
                Console.WriteLine($"{two} x 2 stotinki");
            }
            if (one > 0)
            {

                if (one == 1)
                {
                    Console.WriteLine($"{one} x 1 stotinka");
                }
                else
                {
                    Console.WriteLine($"{one} x 1 stotinki");
                }
            }
        }
    }
}
