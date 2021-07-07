using System;

namespace Phone_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTextMessages = int.Parse(Console.ReadLine());
            int totalMinutes = int.Parse(Console.ReadLine());
            // free cals 60
            // free messages 20 for 12.00
            // each minute more than 60 * 0.10
            // each massage more than 20 * 0.06
            var additionalMessages = 0;
            var additionalMinutes = 0;
            decimal abonamentPrice = 12.00m;

            if (totalTextMessages > 20)
            {
                additionalMessages = totalTextMessages - 20;
            }
            if (totalMinutes > 60)
            {
                additionalMinutes = totalMinutes - 60;
            }

            var plusPrice = ((additionalMessages * 0.06m) + (additionalMinutes * 0.10m));

            var taxPrice = Math.Round(plusPrice * 0.20m, 2);
            var totalPrice = Math.Round(abonamentPrice + plusPrice + taxPrice , 2);

            Console.WriteLine($"{additionalMessages} additional messages for {additionalMessages * 0.06m :f2} levas");
            Console.WriteLine($"{additionalMinutes} additional minutes for {additionalMinutes * 0.10m :f2} levas");
            Console.WriteLine($"{taxPrice} additional taxes");
            Console.WriteLine($"{totalPrice:f2} total bill");
        }
    }
}
