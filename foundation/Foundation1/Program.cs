using System;

class Program
{
    // youtube
    static void Main(string[] args)
    {
        List<Video> video = new List<Video>();
        string title = "Curiousity made me ask";
        string author = "IsBaeU";
        int length = 500;
        Video video1 = new Video(title, author, length);
        
        string name1 = "Ayo";
        string text1 = "This is arguably the best of all series.";
        Comment comment1 = new Comment(name1, text1);

        string name2 = "James";
        string text2 = "Curiosity made me ask is gradually becoming the best online show of 2024";
        Comment comment2 = new Comment(name2, text2);

        string name3 = "John";
        string text3 = "Bae u didn't meet his match, he met the master of the game";
        Comment comment3 = new Comment(name3, text3);
        video1.AddComment(comment1, comment2, comment3);
        video1.NumOfComment();
        video.Add(video1);


        string title2 = "Samsung Galaxy S24 Ultra Review";
        string author2 = "James Teder";
        int length2 = 600;
        Video video2 = new Video(title2, author2, length2);

        string name4 = "Bolu";
        string text4 = "Kinda funny now that everyone has a camera in their pocket, Bigfoot hasn't been seen since.";
        Comment comment4 = new Comment(name4, text4);

        string name5 = "Peter";
        string text5 = "quick answer from a user who pre-ordered and has been using it as a daily driver since - Yes, totally worth it, battery life is fantastic, display is gorgeous, nice and bright out in the sun. love it.";
        Comment comment5 = new Comment(name5, text5);

        string name6 = "Paul";
        string text6 = "You will never be satisfied with any phone if one expects 100% perfection , its still an amazing phone.";
        Comment comment6 = new Comment(name6, text6);
        video2.AddComment(comment4, comment5, comment6);
        video2.NumOfComment();
        video.Add(video2);


        string title3 = "IPhone 16 Pro Max vs Samsung Galaxy S24 Ultra - Which is the Flagship KING?";
        string author3 = "SuperSaf";
        int length3 = 1200;
        Video video3 = new Video(title3, author3, length3);

        string name7 = "Segun";
        string text7 = "The differences are pretty minimal so just buy whatever phone you want";
        Comment comment7 = new Comment(name7, text7);

        string name8 = "Lazzarus";
        string text8 = "Literally every single one of these VS videos ends in the exact same result - they're both great and it comes down to which operating system you prefer! Same answer every year";
        Comment comment8 = new Comment(name8, text8);

        string name9 = "Folake";
        string text9 = "The majority of tech reviewers always mention gaming on the phone, but in my personal experience most people with cell phones don't game on their phone";
        Comment comment9 = new Comment(name9, text9);
        video3.AddComment(comment7, comment8, comment9);
        video3.NumOfComment();
        video.Add(video3);

        string info = "";
        foreach(var videos in video)
        {
            info += $"{videos.DisplayVideoInformation()}\n{videos.DisplayComments()}\n";
        }
        Console.WriteLine(info);
    }
}