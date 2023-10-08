using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> _shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 8);
        _shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Grey", 4, 8);
        _shapes.Add(shape2);

        Circle shape3 = new Circle("Green", 10);
        _shapes.Add(shape3);

        Triangle shape4 = new Triangle("Purple", 4, 5);
        _shapes.Add(shape4);

        RegularPolygon shape5 = new RegularPolygon("Red", 8, 30);
        _shapes.Add(shape5);

        Console.Clear();
        foreach (Shape shape in _shapes)
        {
            string name = shape.GetName();
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {name} is {color} and has an area of {area} units squared.");

        }

    }
}