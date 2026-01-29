using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Learn C# in 10 Minutes", "CodeMaster2000", 600);
        v1.AddComment(new Comment("Jose34", "Great tutorial!"));
        v1.AddComment(new Comment("Maria65", "Can you cover classes next?"));
        v1.AddComment(new Comment("JoseSmith", "C# looks harder than Python."));
        videos.Add(v1);

        Video v2 = new Video("Top 10 Programming Mistakes", "TechGuru", 850);
        v2.AddComment(new Comment("Jose34", "I make mistake #3 all the time."));
        v2.AddComment(new Comment("Maria65", "Nice catch on the memory leak issue."));
        v2.AddComment(new Comment("JoseSmith", "Thanks for the tips!"));
        videos.Add(v2);

        Video v3 = new Video("Day in the Life of a Software Engineer", "SiliconValleyDev", 1200);
        v3.AddComment(new Comment("Maria65", "This is my dream career."));
        v3.AddComment(new Comment("BrighamYoung", "Is it really that stress-free?"));
        v3.AddComment(new Comment("JoseSmith", "What degree do I need?"));
        v3.AddComment(new Comment("Artis26", "That's a lot of coffee."));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
        }
    }
}