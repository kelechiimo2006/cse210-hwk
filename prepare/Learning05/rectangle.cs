public class Rectangle : Shape
{
    private double _length = 5;
    private double _width = 6;
    
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}