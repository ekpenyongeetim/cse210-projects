public class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string Date => _date;
    public int Duration => _duration;

    // Virtual methods for calculation
    public virtual double Distance() => 0;
    public virtual double Speed() => 0;
    public virtual double Pace() => 0;

    // Summary method
    public virtual string GetSummary()
    {
    string activityType = this.GetType().Name; // Get the name of the derived class (e.g., Running, Cycling, Swimming)
    return $"{Date} {activityType} ({Duration} min):\n" +
           $"    Distance: {Distance():0.0} km\n" +
           $"    Speed: {Speed():0.0} kph\n" +
           $"    Pace: {Pace():0.0} min per km\n";
}
}