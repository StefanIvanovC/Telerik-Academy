using System;
public class Program
{
    public static void Main()
    {
        int r = (150 - 20) / 2 + 5;
        Console.WriteLine($"r = {r}"); // 70

        // Expression for calculation of circle area
        double surface = Math.PI * r * r;
        Console.WriteLine($"surface = {surface}"); // 15393,804003

        // Expression for calculation of circle perimeter
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine($"perimeter = {perimeter}"); // 439,822971502571

        // Expression of type int (evaluated at compile time)
        int a = 2 + 3; // a = 5
        Console.WriteLine($"a = {a}");

        // Expression of type int (evaluated at runtime)
        int b = (a + 3) * (a - 4) + (2 * a + 7) / 4;  // b = 12
        Console.WriteLine($"b = {b}");

        // Expression of type bool (evaluated at runtime)
        bool greater = (a > b) || ((a == 0) && (b == 0)); // greater  =  false
        Console.WriteLine($"greater = {greater}");

        // Expression of type double (evaluated at runtime)
        double c = (double)(a + b) / b; // c = 1.416666666666667
        Console.WriteLine($"c = {c}");

        // Expression of type double (evaluated as int first)
        double d = ((a + b) / b); // d = 1
        Console.WriteLine($"d = {d}");
    }
}