using System;
using System.Globalization;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();

             char[] arr = N.ToCharArray();
             var sum = 0;


             for (int i = 0; i < arr.Length; i++)
             {
                 var current = CharUnicodeInfo.GetDecimalDigitValue(arr[i]);


                 if (current == '-' || current == '.')
                 {
                     continue;
                 }

                 if (sum + current > 9)
                 {
                     sum = 0;
                     current -= sum;
                     sum += current;
                 }
                 else
                 {
                     sum += current;
                 }

             }

             Console.WriteLine(sum);


         /*   string N = Console.ReadLine();

            do
            {
                var result = (N.ToList().Where(x => Char.IsDigit(x)).Sum(x => x - 48).ToString());
                N = result;
            }
            while (N.Length > 1);
            {
                Console.WriteLine(N);
            }*/


        }
    }
}
