using System.Formats.Asn1;
using System.Runtime.InteropServices;

public class Circle : Shape
{
    private double _radius = 5;

public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
        
public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }
}