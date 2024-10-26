public class Circle : Shape
{
    private double _radius;

    // Constructor for Circle, accepting color and radius
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea to return area of a circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
