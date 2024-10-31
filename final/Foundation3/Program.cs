public class Program
{
    public static void Main(string[] args)
    {
        // Create activity instances
        Activity running = new Running("03 Nov 2022", 30, 4.8);  // 4.8 km in 30 min
        Activity cycling = new Cycling("03 Nov 2022", 45, 20);   // 20 kph for 45 min
        Activity swimming = new Swimming("03 Nov 2022", 25, 30); // 30 laps in 25 min

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}