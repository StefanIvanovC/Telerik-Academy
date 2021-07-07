using System;

namespace TipsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var bill = double.Parse(Console.ReadLine());
            var tipProsentage = 0.10;

            var result = bill + (bill * tipProsentage);
            Console.WriteLine(result);
        }
    }
}
