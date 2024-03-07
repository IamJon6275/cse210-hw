using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("blue", 2);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("red", 2, 4);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("octarine", 3);
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            Console.WriteLine(shape.GetColor());
            double area = shape.GetArea();
            Console.WriteLine(shape.GetArea());
        }
    }
}