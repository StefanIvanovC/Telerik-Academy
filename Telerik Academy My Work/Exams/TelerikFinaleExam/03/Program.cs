using System;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int isLower = 0;
            int isUpper = 0;
            int isDigit = 0;
            int isSymbol = 0;
            string print = "";
            int missing = 0;

            foreach (char c in input)
            {
                if (Char.IsLower(c))
                {
                    isLower++;
                }
                if (Char.IsUpper(c))
                {
                    isUpper++;
                }
                if (Char.IsDigit(c))
                {
                    isDigit++;
                }
                if (c == '!' || c == '@' || c == '#' || c == '$' || c == '%' || c == '^' || c == '&' || c == '*'
                    || c == '(' || c == ')' || c == '_' || c == '+' || c == '-' || c == '=' || c == '>' || c == '<'
                    || c == '?') //(!@#$%^&*()_+-=><?)
                {
                    isSymbol++;
                }
            }

            if (isLower < 3)
            {
                var result = 3 - isLower;
                print += $"{result} lowercase ";
                missing += result;
            }
            if (isUpper < 3)
            {
                if (print != "")
                {
                    print += "and ";
                }
                var result = 3 - isUpper;
                print += $"{result} uppercase ";
                missing += result;
            }
            if (isDigit < 3)
            {
                if (print != "")
                {
                    print += "and ";
                }
                var result = 3 - isDigit;
                print += $"{result} digits ";
                missing += result;
            }
            if (isSymbol < 3)
            {
                if (print != "")
                {
                    print += "and ";
                }
                var result = 3 - isSymbol;
                print += $"{result} special ";
                missing += result;
            }

            if (input.Length < 15)
            {
                var result = 15 - input.Length;
                Console.WriteLine(result);
                //  Console.WriteLine("insufficient length");
            }
            else if (print != "")
            {
                Console.WriteLine(missing);
                print += $"chars missing";
                // Console.WriteLine(print);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
