using System;

// public class Fraction
// {
//     private int _numerator;
//     private int _denominator;

//     // Default constructor initializing to 1/1
//     public Fraction()
//     {
//         _numerator = 1;
//         _denominator = 1;
//     }

//     // Constructor initializing to a whole number (wholeNumber/1)
//     public Fraction(int wholeNumber)
//     {
//         _numerator = wholeNumber;
//         _denominator = 1;
//     }

//     // Constructor initializing to a specific fraction (numerator/denominator)
//     public Fraction(int numerator, int denominator)
//     {
//         if (denominator == 0)
//         {
//             throw new ArgumentException("Denominator cannot be zero.");
//         }
//         _numerator = numerator;
//         _denominator = denominator;
//     }

//     // Method to get the fraction as a string
//     public string GetFractionString()
//     {
//         return $"{_numerator}/{_denominator}";
//     }

//     // Method to get the decimal value of the fraction
//     public double GetDecimalValue()
//     {
//         return (double)_numerator / _denominator;
//     }
// }

// // Example usage:
// class Program
// {
//     static void Main(string[] args)
//     {
//         Fraction defaultFraction = new Fraction();
//         Console.WriteLine(defaultFraction.GetFractionString()); // Output: 1/1
//         Console.WriteLine(defaultFraction.GetDecimalValue());   // Output: 1

//         Fraction wholeNumberFraction = new Fraction(5);
//         Console.WriteLine(wholeNumberFraction.GetFractionString()); // Output: 5/1
//         Console.WriteLine(wholeNumberFraction.GetDecimalValue());   // Output: 5

//         Fraction specificFraction = new Fraction(3, 4);
//         Console.WriteLine(specificFraction.GetFractionString()); // Output: 3/4
//         Console.WriteLine(specificFraction.GetDecimalValue());   // Output: 0.75
//     }
// }
using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
    
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }


}