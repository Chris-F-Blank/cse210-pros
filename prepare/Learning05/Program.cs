using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creates instances of the shapes
        Square square = new Square("Red", 4.0);
        Rectangle rectangle = new Rectangle("Blue", 3.0, 5.0);
        Circle circle = new Circle("Green", 2.5);

        // Tests individual shapes
        Console.WriteLine($"Square - Color: {square.Color}, Area: {square.GetArea()}");
        Console.WriteLine($"Rectangle - Color: {rectangle.Color}, Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle - Color: {circle.Color}, Area: {circle.GetArea()}");

        // Creates a list of shapes
        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        // Iterates through the list of shapes and display their color and area (finally got it to work!!!)
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape - Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}
