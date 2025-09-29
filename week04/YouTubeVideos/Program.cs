using System;

public class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# in 10 Minutes", "Tech Guru", 600);
        video1.AddComment(new Comment("Gualter", "Great explanation!"));
        video1.AddComment(new Comment("Santos", "Very helpful, thanks."));
        video1.AddComment(new Comment("Ella", "Can you do one for Java too?"));

        Video video2 = new Video("Top 10 Programming Languages", "Code Master", 900);
        video2.AddComment(new Comment("Ezra", "Python should be number 1!"));
        video2.AddComment(new Comment("Mateus", "Nice breakdown, loved it."));
        video2.AddComment(new Comment("Rui", "C++ is underrated."));

        Video video3 = new Video("History of Computers", "Tech Historian", 1200);
        video3.AddComment(new Comment("Ana", "Very informative."));
        video3.AddComment(new Comment("Elsa", "Loved the old computer pictures!"));
        video3.AddComment(new Comment("Paulo", "Please make a part 2."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}