using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(4, 5);
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
    }
}