using System;
public class Program
{
    public static void Main()
    {
        bool a = true;
        bool b = false;
        Console.WriteLine($"a is {a}"); // True
        Console.WriteLine($"b is {b}"); // False
        // && - AND
        Console.WriteLine($"a ({a}) && b ({b}) is {a && b}"); // False
        // || - OR
        Console.WriteLine($"a ({a}) || b ({b}) is {a || b}"); // True
        // ! - NOT
        Console.WriteLine($"!b ({b}) = {!b}"); // True
        Console.WriteLine($"b || True is {b || true}"); // True
        Console.WriteLine($"b && True is {b && true}"); // False
        Console.WriteLine($"a || True is {a || true}"); // True
        Console.WriteLine($"a && True is {a && true}"); // True
        Console.WriteLine($"!a is {!a}"); // False
    }
}