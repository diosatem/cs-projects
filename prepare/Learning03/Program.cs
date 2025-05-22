using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        // Step 5 verification with getters and setters
        // Fraction fraction1 = new Fraction();
        // Console.WriteLine($"Fraction1: {fraction1.GetTop()}/{fraction1.GetBottom()}");


        // Fraction fraction2 = new Fraction(6);
        // Console.WriteLine($"Fraction2: {fraction2.GetTop()}/{fraction2.GetBottom()}");

        // Fraction fraction3 = new Fraction(6, 7);
        // Console.WriteLine($"Fraction3: {fraction3.GetTop()}/{fraction3.GetBottom()}");


        //Step 6 verification with methods
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction1: {f1.GetFractionString()}");
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5, 1);
        Console.WriteLine($"Fraction2: {f2.GetFractionString()}");
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction3: {f3.GetFractionString()}");
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction5: {f4.GetFractionString()}");
        Console.WriteLine(f4.GetDecimalValue());

    }
}