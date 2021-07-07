using System;
public class Program
{
    public static void Main()
    {
        // Comparison operators
        int a = 5;
        int b = 4;
        Console.WriteLine(a >= b); // True
        Console.WriteLine(a != b); // True
        Console.WriteLine(a != ++b); // False (first increments b to 5 and THEN checks if a is not equal to b)
        Console.WriteLine(a > b); // False
    }
}