public class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double Distance() => _distance;

    public override double Speed() => (Distance() / Duration) * 60;

    public override double Pace() => Duration / Distance();

}