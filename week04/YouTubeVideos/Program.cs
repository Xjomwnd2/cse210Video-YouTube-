using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("Coding Tutorial", "Tech Guru", 1200);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful explanation."));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        Video video2 = new Video("Cooking Show", "Chef Master", 1800);
        video2.AddComment(new Comment("David", "Delicious recipe!"));
        video2.AddComment(new Comment("Eve", "Can't wait to try this."));
        video2.AddComment(new Comment("Frank", "Amazing cooking techniques."));
        videos.Add(video2);

        Video video3 = new Video("Travel Vlog", "World Explorer", 2400);
        video3.AddComment(new Comment("Grace", "Beautiful scenery!"));
        video3.AddComment(new Comment("Henry", "Inspiring adventure."));
        video3.AddComment(new Comment("Ivy", "Loved the cultural insights."));
        videos.Add(video3);

        // Display video and comment information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(); // Empty line for readability
        }
    }
}