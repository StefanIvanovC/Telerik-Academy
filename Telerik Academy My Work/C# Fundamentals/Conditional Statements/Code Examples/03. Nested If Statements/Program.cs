using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers (on separate lines).");
        Console.Write("first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("second number: ");
        int second = int.Parse(Console.ReadLine());

        if (first == second)
        {
            Console.WriteLine("These two numbers are equal.");
        }
        else
        {
            if (first > second)
            {
                Console.WriteLine("The first number is greater.");
            }
            else
            {
                Console.WriteLine("The second number is greater.");
            }
        }
    }
}
