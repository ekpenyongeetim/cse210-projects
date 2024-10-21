class Assignment
{
    // Private member variables for student name and topic
    private string _studentName;
    private string _topic;

    // Constructor to initialize the assignment with student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return a summary of the assignment
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    // Public getter method to access the student name (for derived classes)
    public string GetStudentName()
    {
        return _studentName;
    }
}
