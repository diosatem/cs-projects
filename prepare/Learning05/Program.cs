using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("purple", 10);
        // Console.WriteLine($"Square color: {square.GetColor()}");
        // Console.WriteLine($"Square area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("yellow", 10, 5);
        // Console.WriteLine($"Rectangle color: {rectangle.GetColor()}");
        // Console.WriteLine($"Rectangle color: {rectangle.GetArea()}");

        Circle circle = new Circle("red", 20);
        // Console.WriteLine($"Circle color: {circle.GetColor()}");
        // Console.WriteLine($"Circle color: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()}");
        }
    }
}