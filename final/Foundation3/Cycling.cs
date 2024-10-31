public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double Speed() => _speed;

    public override double Distance() => (Speed() * Duration) / 60;

    public override double Pace() => 60 / Speed();

}