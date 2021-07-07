using System;
using System.Linq;

namespace _03.Word_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var firstWord = String.Concat(word.OrderBy(c => c)); 
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string word2 = Console.ReadLine();
                var secondWord = String.Concat(word2.OrderBy(x => x));

                if (firstWord == secondWord)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
        }
    }
}
