using System;

public class Program
{
    public static void Main()
    {
        // Read Array
        Console.WriteLine("Enter numbers on a single line, separated by a space:");
        string[] numbersAsStrings = Console.ReadLine().Split(' ');

        int[] numbers = new int[numbersAsStrings.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);
        }

        // Find Sum 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Print Formatted Array
        string formattedArray = string.Join(" + ", numbers);
        Console.WriteLine($"{formattedArray} = {sum}");
    }
}