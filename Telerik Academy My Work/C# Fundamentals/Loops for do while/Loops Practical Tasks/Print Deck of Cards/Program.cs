using System;

namespace Print_Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            if (card == "J")
            {
                card = "11";
            }
            else if (card == "Q")
            {
                card = "12";
            }
            else if (card == "K")
            {
                card = "13";
            }
            else if (card == "A")
            {
                card = "14";
            }
          
            for (int i = 2; i <= int.Parse(card); i++)
            {
                if (i == 11)
                {
                    Console.WriteLine($"J of spades, J of clubs, J of hearts, J of diamonds");
                    continue;
                }
                else if (i == 12)
                {
                    Console.WriteLine($"Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    continue;
                }
                else if (i == 13)
                {
                    Console.WriteLine($"K of spades, K of clubs, K of hearts, K of diamonds");
                    continue;
                }
                else if (i == 14)
                {
                    Console.WriteLine($"A of spades, A of clubs, A of hearts, A of diamonds");
                    continue;
                }
                
                Console.WriteLine($"{i} of spades, {i} of clubs, {i} of hearts, {i} of diamonds");
            }
        }
    }
}
