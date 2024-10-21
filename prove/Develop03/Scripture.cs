class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.Write(_reference.GetReference() + ": ");

        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}