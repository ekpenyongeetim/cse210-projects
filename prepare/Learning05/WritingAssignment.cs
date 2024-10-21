class WritingAssignment : Assignment
{
    // Private member variable specific to writing assignments
    private string _title;

    // Constructor to initialize all member variables including those from the base class
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to return the writing assignment details
    public string GetWritingInformation()
    {
        return _title + " by " + GetStudentName();
    }
}
