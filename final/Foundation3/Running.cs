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

    public override string GetSummary()
    {
        return $"{Date} Running ({Duration} min): Distance {Distance():0.0} km, " +
               $"Speed {Speed():0.0} kph, Pace {Pace():0.0} min per km";
    }
}