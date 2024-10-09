using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructor with no parameters (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test constructor with one parameter (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test constructor with two parameters (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Test constructor with two parameters (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test getters and setters
        f4.SetNumerator(2);
        f4.SetDenominator(3);
        Console.WriteLine($"Updated fraction: {f4.GetNumerator()}/{f4.GetDenominator()}");
        Console.WriteLine(f4.GetDecimalValue());
    }
}