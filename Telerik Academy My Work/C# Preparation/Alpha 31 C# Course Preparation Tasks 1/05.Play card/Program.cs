using System;
using System.Linq;

namespace _05.Play_card
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None).ToArray();
            string[] validCards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            foreach (var card in input)
            {
                if (validCards.Contains(card))
                {
                    Console.WriteLine($"yes {card}");
                }
                else
                {
                    Console.WriteLine($"no {card}");
                }
            }
        }
    }
}
