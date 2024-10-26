public class Square : Shape
{
    private double _side;

    // Constructor for Square, accepting color and side length
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea to return area of a square
    public override double GetArea()
    {
        return _side * _side;
    }
}
