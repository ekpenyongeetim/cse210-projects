
class BreathingActivity : Activity
{
    // Constructor that sets the specific description for breathing activity
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Method to run the breathing activity
    public void RunBreathing()
    {
        StartActivity();
        int duration = GetDuration();
        for (int i = 0; i < duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }
        EndActivity();
    }
}
