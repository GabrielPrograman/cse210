using System;
using System.Collections.Generic;

namespace YoutubeVideos
{
    
class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video("C# Classes and Objects Tutorial", "ProgrammingWithJohn", 620);
        video1.AddComment(new Comment("Alice Smith", "This cleared up all my doubts about constructors"));
        video1.AddComment(new Comment("Bob Jones", "Great pacing, thanks for the clear examples"));
        video1.AddComment(new Comment("Charlie Brown", "Can you make a video about inheritance next?"));
        videosList.Add(video1);

        Video video2 = new Video("Exploring Cumaná: The First City of the Americas", "VeneTravels", 1240);
        video2.AddComment(new Comment("Maria V.", "Beautiful footage of the San Antonio de la Eminencia castle!"));
        video2.AddComment(new Comment("Carlos M.", "I miss the beaches of Sucre so much, Great video"));
        video2.AddComment(new Comment("Elena77", "Adding this city to my travel bucket list right now."));
        videosList.Add(video2);

        Video video3 = new Video("How to Optimize Images for Web Performance", "WebDevSpecs", 450);
        video3.AddComment(new Comment("DevDavid", "Keeping files under 125kb is key, totally agree!"));
        video3.AddComment(new Comment("Sarah_UX", "Using modern formats like WebP makes a massive difference."));
        video3.AddComment(new Comment("TechGuru", "Simple, concise, and highly informative tutorial"));
        videosList.Add(video3);

        Console.WriteLine("### YOUTUBE VIDEO TRACKING REPORT ###\n");
        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
        }
    }
}
}