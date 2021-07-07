using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesPerGalon = double.Parse(Console.ReadLine());
            double kmPerGalon = milesPerGalon * 1.6; 
            double kmPerLitre = kmPerGalon / 4.54;
            double litrePer100km = Math.Floor(100 / kmPerLitre);
            Console.WriteLine($"{litrePer100km} litres per 100 km");
        }
    }
}
