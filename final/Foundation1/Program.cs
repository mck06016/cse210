using System;

class Program
{
    static void Main(string[] args)
    {
        //Load 4 videos with 3-8 Comments Each. 
        Console.Clear();

        //Video 1
        Video video1 = new("How to make Sour Dough", "Gwen McKenzie", 522);
        video1._comments.Add(new Comment("Julia McKenzie", "Best tasting Sour Dough Bread."));
        video1._comments.Add(new Comment("Paige Irwin", "Insightful instruction and very useful tips."));
        video1._comments.Add(new Comment("Melissa Carlton", "It took a while to get the starter right, but this is the best bread recipe. I always have some in my fridge."));
        video1._comments.Add(new Comment("Steve Leavitt", "I am getting fat eating all this bread. My wife started making this and I cannot stop eating it."));
        video1._comments.Add(new Comment("Neil McKenzie", "If you love the sour dough recipe, go and check out her basic bread recipe."));

        video1.DisplayVideo();

        //Video 2
        Video video2 = new("Two", "Author 2", 300);
        video2._comments.Add(new Comment("Poster A", "Comment A"));
        video2._comments.Add(new Comment("Poster B", "Comment B"));
        video2._comments.Add(new Comment("Poster C", "Comment C"));

        video2.DisplayVideo();

        //Video 3
        Video video3 = new("Three", "Author 3", 800);
        video3._comments.Add(new Comment("Poster 1", "Comment 1"));
        video3._comments.Add(new Comment("Poster 2", "Comment 2"));
        video3._comments.Add(new Comment("Poster 3", "Comment 3"));
        video3._comments.Add(new Comment("Poster 4", "Comment 4"));
        video3._comments.Add(new Comment("Poster 5", "Comment 5"));
        video3._comments.Add(new Comment("Poster 6", "Comment 6"));

        video3.DisplayVideo();

        //Video 4
        Video video4 = new("Four", "Author 4", 5000);
        video4._comments.Add(new Comment("Poster !", "Comment !"));
        video4._comments.Add(new Comment("Poster @", "Comment @"));
        video4._comments.Add(new Comment("Poster #", "Comment #"));
        video4._comments.Add(new Comment("Poster *", "Comment *"));

        video4.DisplayVideo();

    }
}