using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        Fraction frac1 = new Fraction();
        // frac1.fraction();
        // frac1.SetTop(1);
        // Console.WriteLine(frac1.GetTop());
        // frac1.SetBottom(1);
        // Console.WriteLine(frac1.GetBottom());
        // frac1.fraction(6);
        // frac1.SetTop(6);
        // Console.WriteLine(frac1.GetTop());
        // frac1.SetBottom(1);
        // Console.WriteLine(frac1.GetBottom());
        // frac1.fraction(6, 7);
        // frac1.SetTop(6);
        // Console.WriteLine(frac1.GetTop());
        // frac1.SetBottom(7);
        // Console.WriteLine(frac1.GetBottom());
        frac1.fraction();
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        frac1.fraction(5);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        frac1.fraction(3, 4);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        frac1.fraction(1, 3);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
    }
}