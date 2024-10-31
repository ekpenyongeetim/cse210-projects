public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double Distance() => (_laps * 50) / 1000.0;

    public override double Speed() => (Distance() / Duration) * 60;

    public override double Pace() => Duration / Distance();

    public override string GetSummary()
    {
        return $"{Date} Swimming ({Duration} min): Distance {Distance():0.0} km, " +
               $"Speed {Speed():0.0} kph, Pace {Pace():0.0} min per km";
    }
}