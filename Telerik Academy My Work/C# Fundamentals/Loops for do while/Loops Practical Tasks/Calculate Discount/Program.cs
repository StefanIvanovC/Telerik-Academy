using System;

namespace Calculate_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double discount = price * 0.65;
                double priceWithDiscount = price - discount;

                Console.WriteLine($"{priceWithDiscount:f2}");
            }
        }
    }
}
