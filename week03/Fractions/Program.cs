using System;

class Program
{
    static void Main(string[] args)
    {
        // Create fractions
        Fraction first = new Fraction();
        Fraction second = new Fraction(5);
        Fraction third = new Fraction(3, 4);
        Fraction fourth = new Fraction(1, 3);

        // Display first fraction
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Console.WriteLine();

        // Display second fraction
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Console.WriteLine();

        // Display third fraction
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        Console.WriteLine();

        // Display fourth fraction
        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());

        Console.WriteLine();

        // Testing setters and getters
        fourth.SetTop(5);
        fourth.SetBottom(8);

        Console.WriteLine("Updated Fraction:");
        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());
    }
}