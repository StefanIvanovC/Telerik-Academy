using System;

namespace Guess_the_Season
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int date = int.Parse(Console.ReadLine());
            string season = "";

            switch (month)
            {
                case "March":
                    if (date >= 1 && date <= 20)
                    {
                        season = "Winter";
                        break;
                    }
                    else
                    {
                        season = "Spring";
                        break;
                    }
                case "April":
                    if (date >= 1 && date <= 30)
                    {
                        season = "Spring";
                        break;
                    }
                    break;
                case "May":
                    if (date >= 1 && date <= 31)
                    {
                        season = "Spring";
                        break;
                    }
                    break;
                case "June":
                    if (date >= 1 && date <= 23)
                    {
                        season = "Spring";
                        break;
                    }
                    else season = "Summer";
                    break;
                case "July":
                    if (date >= 1 && date <= 31)
                    {
                        season = "Summer";
                        break;
                    }
                    break;
                case "August":
                    if (date >= 1 && date <= 31)
                    {
                        season = "Summer";
                        break;
                    }
                    break;
                case "September":
                    if (date >= 1 && date <= 21)
                    {
                        season = "Summer";
                        break;
                    }
                    else
                    {
                        season = "Autumn";
                        break;
                    }
                case "October":
                    if (date >= 1 && date <= 31)
                    {
                        season = "Autumn";
                        break;
                    }
                    break;
                case "November":
                    if (date >= 1 && date <= 31)
                    {
                        season = "Autumn";
                        break;
                    }
                    break;
                case "December":
                    if (date >= 1 && date <= 20)
                    {
                        season = "Autumn";
                    }
                    else
                    {
                        season = "Winter";
                    }
                    break;
                case "January":
                    if (date >= 1 && date <= 31)
                    {
                        season = "Winter";
                    }
                    break;
                case "February":
                    if (date >= 1 && date <=29)
                    {
                        season = "Winter";
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine(season);
        }
    }
}
