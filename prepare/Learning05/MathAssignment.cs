class MathAssignment : Assignment
{
    // Private member variables specific to Math assignments
    private string _textbookSection;
    private string _problems;

    // Constructor to initialize all member variables including those from the base class
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to return the math homework details
    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}
