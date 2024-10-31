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
        return $"{Date} Activity ({Duration} min): Distance {Distance():0.0} km, " +
               $"Speed {Speed():0.0} kph, Pace {Pace():0.0} min per km";
    }
}