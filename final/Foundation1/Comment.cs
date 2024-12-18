// Comment class to track each comment's name and message
class Comment
{
    public string Name { get; set; }
    public string Message { get; set; }

    public Comment(string name, string message)
    {
        Name = name;
        Message = message;
    }
}