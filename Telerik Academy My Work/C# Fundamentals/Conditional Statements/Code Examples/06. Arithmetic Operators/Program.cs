using System;
public class Program
{
    public static void Main()
    {
        int squarePerimeter = 17;
        double squareSide = squarePerimeter / 4.0;
        double squareArea = squareSide * squareSide;
        Console.WriteLine(squareSide); // 4.25
        Console.WriteLine(squareArea); // 18.0625

        int n1 = 5;
        int n2 = 4;
        Console.WriteLine(n1 + n2); // 9
        Console.WriteLine(n1 + n2++); // 9
        Console.WriteLine(n1 + n2); // 10
        Console.WriteLine(n1 + (++n2)); // 11
        Console.WriteLine(n1 + n2); // 11

        Console.WriteLine(11 / 3); // 3
        Console.WriteLine(11 % 3); // 2
        Console.WriteLine(12 / 3); // 4

        Console.WriteLine(11.0 / 3); // 3.66666666666665
        Console.WriteLine(11 / 3.0); // 3.66666666666665
        Console.WriteLine(11 % 3);   // 2
        Console.WriteLine(11 % -3);  // 2
        Console.WriteLine(-11 % 3);  // -2

        Console.WriteLine("1.5 / 0.0 = " + (1.5 / 0.0)); // Infinity
        Console.WriteLine("-1.5 / 0.0 = " + (-1.5 / 0.0)); // -Infinity
        Console.WriteLine("0.0 / 0.0 = " + (0.0 / 0.0)); // NaN

        // This will produce DivideByZeroException
        //int x = 0;
        //Console.Console.WriteLine("5 / 0 = " + (5 / x));

        int bigNum = 2000000000;
        int bigSum = 2 * bigNum; // Integer overflow!
        Console.WriteLine(bigSum); // -294967296

        bigNum = int.MaxValue;
        bigNum = bigNum + 1;
        Console.WriteLine(bigNum); // -2147483648
    }
}