// Manages the collection of entries in the journal
public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Adds a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays all the entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found in the journal.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    // Saves the journal to a specified file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {file} successfully!");
    }

    // Loads the journal entries from a specified file
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                string[] parts = line.Split("~|~");
                if (parts.Length == 3)
                {
                    Entry loadedEntry = new Entry(parts[1], parts[2])
                    {
                        _date = parts[0]
                    };
                    _entries.Add(loadedEntry);
                }
            }
            Console.WriteLine($"Journal loaded from {file} successfully!");
        }
        else
        {
            Console.WriteLine($"File {file} does not exist.");
        }
    }
}