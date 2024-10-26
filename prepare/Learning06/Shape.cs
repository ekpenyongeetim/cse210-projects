public abstract class Shape
{
    // Member variable for color
    public string Color { get; set; }

    // Constructor to initialize color
    protected Shape(string color)
    {
        Color = color;
    }

    // Virtual method to get the area (abstract since each shape has a unique calculation)
    public abstract double GetArea();

    // Method to get color
    public string GetColor()
    {
        return Color;
    }
}
