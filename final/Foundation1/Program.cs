class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video pastaVideo = new Video("How to Cook Pasta", "Chef Mike", 600);
        Video travelVideo = new Video("Top 10 Places to Visit", "Traveler Tom", 900);
        Video yogaVideo = new Video("Beginner Yoga Session", "Yoga Teacher Lily", 1200);

        // Add comments to pastaVideo
        pastaVideo.AddComment(new Comment("John", "Awesome recipe!"));
        pastaVideo.AddComment(new Comment("Emily", "Tried it and loved it!"));
        pastaVideo.AddComment(new Comment("Sara", "Easy and delicious."));

        // Add comments to travelVideo
        travelVideo.AddComment(new Comment("Alex", "I want to visit these places!"));
        travelVideo.AddComment(new Comment("Chris", "Thanks for the tips."));
        travelVideo.AddComment(new Comment("Jamie", "Great video!"));

        // Add comments to yogaVideo
        yogaVideo.AddComment(new Comment("Lucy", "Loved the yoga session."));
        yogaVideo.AddComment(new Comment("Mark", "Great for beginners."));
        yogaVideo.AddComment(new Comment("Olivia", "Very relaxing and easy to follow."));

        // Create a list to hold all the videos
        List<Video> videos = new List<Video> { pastaVideo, travelVideo, yogaVideo };

        // Show the video information and comments for each video
        foreach (Video video in videos)
        {
            video.ShowVideoInfo();
        }
    }
}