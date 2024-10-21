class Video
{
    public string VideoTitle { get; set; }
    public string VideoCreator { get; set; }
    public int VideoLength { get; set; } // Video length in seconds
    private List<Comment> CommentsList; // List of comments on the video

    public Video(string title, string creator, int length)
    {
        VideoTitle = title;
        VideoCreator = creator;
        VideoLength = length;
        CommentsList = new List<Comment>();
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        CommentsList.Add(comment);
    }

    // Get the total number of comments
    public int GetCommentCount()
    {
        return CommentsList.Count;
    }

    // Show the video information and its comments
    public void ShowVideoInfo()
    {
        Console.WriteLine($"Title: {VideoTitle}");
        Console.WriteLine($"Creator: {VideoCreator}");
        Console.WriteLine($"Length: {VideoLength} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}\n");

        foreach (Comment comment in CommentsList)
        {
            Console.WriteLine($"Comment by {comment.Name}: {comment.Message}");
        }
        Console.WriteLine();
    }
}