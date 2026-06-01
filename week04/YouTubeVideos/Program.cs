using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Introduction to Programming", "Tech Academy", 420);
        v1.AddComment(new Comment("Alice", "Very clear explanation"));
        v1.AddComment(new Comment("Brian", "Helped me understand basics"));
        v1.AddComment(new Comment("Cynthia", "Great teaching style"));
        videos.Add(v1);

        Video v2 = new Video("Healthy Cooking Tips", "Home Kitchen", 600);
        v2.AddComment(new Comment("David", "Very informative"));
        v2.AddComment(new Comment("Ella", "I will try this recipe"));
        v2.AddComment(new Comment("Frank", "Simple and easy to follow"));
        videos.Add(v2);

        Video v3 = new Video("Basic Mathematics Tutorial", "LearnFast", 360);
        v3.AddComment(new Comment("Grace", "This really helped me"));
        v3.AddComment(new Comment("Henry", "Well explained"));
        v3.AddComment(new Comment("Ivy", "Good examples used"));
        videos.Add(v3);

        Video v4 = new Video("Introduction to Public Speaking", "Skill Builder", 500);
        v4.AddComment(new Comment("James", "Very useful tips"));
        v4.AddComment(new Comment("Kemi", "I feel more confident now"));
        v4.AddComment(new Comment("Liam", "Great presentation"));
        videos.Add(v4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}