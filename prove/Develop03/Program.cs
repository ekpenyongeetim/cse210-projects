using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture reference and scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Run the memorization program
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress enter to hide more words, or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // Hide 3 random words at a time
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Program ended.");
    }
}
