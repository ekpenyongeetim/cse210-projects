class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    // Constructor to set the activity name and description
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    // Method to start the activity, including setting duration and displaying starting message
    public void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName}");
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds would you like this activity to last?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // Pause before starting
    }

    // Method to display the common ending message
    public void EndActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You did the {_activityName} for {_duration} seconds.");
        ShowSpinner(3); // Pause before finishing
    }

    // Method to get the duration of the activity
    public int GetDuration()
    {
        return _duration;
    }

    // Method to show a simple spinner animation
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    // Method to display a countdown from a certain number of seconds
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}