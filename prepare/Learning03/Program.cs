using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);
        Fraction fraction4 = new Fraction(1,3);


        // Getters and setters for fraction 1 
        //just to see.
        fraction1.SetTop(1);
        fraction1.SetBottom(1);


        // Displaying different representations
        Console.WriteLine("Fraction 1");
        Console.WriteLine($"Top: {fraction1.GetTop()}");
        Console.WriteLine($"Bottom: {fraction1.GetBottom()}");
        Console.WriteLine($"Fraction String: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {fraction1.GetDecimalValue()}");

        Console.WriteLine("");

        Console.WriteLine("Fraction 2");
        Console.WriteLine($"Top: {fraction2.GetTop()}");
        Console.WriteLine($"Bottom: {fraction2.GetBottom()}");
        Console.WriteLine($"Fraction String: {fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {fraction2.GetDecimalValue()}");

        Console.WriteLine("");

        Console.WriteLine("Fraction 3");
        Console.WriteLine($"Top: {fraction3.GetTop()}");
        Console.WriteLine($"Bottom: {fraction3.GetBottom()}");
        Console.WriteLine($"Fraction String: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {fraction3.GetDecimalValue()}");

         Console.WriteLine("");

        Console.WriteLine("Fraction 4");
        Console.WriteLine($"Top: {fraction4.GetTop()}");
        Console.WriteLine($"Bottom: {fraction4.GetBottom()}");
        Console.WriteLine($"Fraction String: {fraction4.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {fraction4.GetDecimalValue()}");



        
        
        
    }
}