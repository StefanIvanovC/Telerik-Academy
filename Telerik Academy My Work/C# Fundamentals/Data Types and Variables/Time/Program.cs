using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int daysInSeconds = days * 24 * 60 * 60;
            int hoursInSeconds = hours * 60 * 60;
            int minutesInSeconds = minutes * 60;

            int result = daysInSeconds + hoursInSeconds + minutesInSeconds + seconds;

            Console.WriteLine(result);
        }
    }
}
