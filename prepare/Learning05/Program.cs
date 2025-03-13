using System;

class Program
{
    static void Main(string[] args)
    {
        List <Shape> _shapes = new List<Shape>();

        Square s1 = new Square("Blue", 5);
        _shapes.Add(s1);

        Rectangle s2 = new Rectangle("Red", 5, 6);
        _shapes.Add(s2);

        Circle s3 = new Circle("Green", 5);
        _shapes.Add(s3);

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
        
    
}