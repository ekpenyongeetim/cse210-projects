// Represents a single journal entry
public class Entry
{
    public string _date;        // Date of the journal entry
    public string _promptText;  // The prompt shown to the user
    public string _entryText;   // The response to the prompt

    public Entry(string prompt, string entryText)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _promptText = prompt;
        _entryText = entryText;
    }

    // Displays the entry details to the console
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("-------------------------------");
    }
}