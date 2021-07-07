using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter count of numbers: ");
        int count = int.Parse(Console.ReadLine());

        // Read Array
        int[] numbers = new int[count];
        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Enter number {i}: ");
            int nextNumber = int.Parse(Console.ReadLine());
            numbers[i - 1] = nextNumber;
        }

        // Find Sum
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }

        Console.WriteLine($"Sum: {sum}");
    }
}