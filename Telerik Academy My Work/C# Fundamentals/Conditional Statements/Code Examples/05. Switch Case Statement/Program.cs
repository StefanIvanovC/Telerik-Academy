using System;
public class Program
{
    static void Main()
    {
        Console.Write("Enter a number in the range [1..7]: ");
        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }

        // Stacking cases
        Console.Write("Please enter some animal: ");
        string animal = Console.ReadLine();
        switch (animal)
        {
            case "dog":
            case "cat":
            case "cow":
                Console.WriteLine("MAMMAL");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("REPTILE");
                break;
            case "hawk":
            case "sparrow":
            case "dove":
                Console.WriteLine("BIRD");
                break;
            default:
                Console.WriteLine("I don't know this animal!");
                break;
        }
    }
}