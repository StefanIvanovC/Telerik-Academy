using System;

public class Program
{
    public static void Main()
    {
        string[] array = { "one", "two", "three", "four" };

        // Process all elements of the array
        for (int index = 0; index < array.Length; index++)
        {
            // Print each element on a separate line
            string value = array[index];
            Console.WriteLine($"The value of the element at index {index} is {value}");
        }
    }
}
