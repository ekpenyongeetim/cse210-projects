class ListingActivity : Activity
{
    private List<string> _prompts;

    // Constructor that sets the specific description for listing activity and initializes prompts
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Method to run the listing activity
    public void RunListing()
    {
        StartActivity();
        int duration = GetDuration();
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        ShowSpinner(3); // Pause before listing items

        List<string> userEntries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("List an item:");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                userEntries.Add(item);
            }
        }
        Console.WriteLine($"You listed {userEntries.Count} items.");
        EndActivity();
    }
}
