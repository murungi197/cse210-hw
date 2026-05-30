using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video

{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    private List<Comment> Comments = new List<Comment>();

    public void AddComment(Comment comm)
    {
        Comments.Add(comm);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"comments: {GetCommentCount()}");

        foreach (Comment c in Comments)
        {
            Console.WriteLine($"Comment by {c.Name}: {c.Text}");
        }
        }



class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();

        Video v1 = new Video { Title = "C# Tutorial for Beginners", Author = "Mosh Hamedani", Length = 600 };
        v1.AddComment(new Comment("Murungi", "Great tutorial!"));
        v1.AddComment(new Comment("Innocent", "Very helpful, thanks!"));
        v1.AddComment(new Comment("Mercy", "I learned a lot from this video."));

        Video v2 = new Video { Title = "Learn Python in 10 Minutes", Author = "Programming with Mosh", Length = 600 };
        v2.AddComment(new Comment("Martin", "Awesome video Hamedani!"));
        v2.AddComment(new Comment("Alice", "This is a great introduction to Python i have ever came across."));
        v2.AddComment(new Comment("Greg", "Thanks for sharing this!"));

        videos.Add(v1);
        videos.Add(v2);

        foreach (Video v in videos)
        {
            v.Display();
        }    
    }
}
}






















