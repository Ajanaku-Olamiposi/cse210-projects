using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();

    public void AddComment(Comment comment1, Comment comment2, Comment comment3)
    {
        _comment.Add(comment1);
        _comment.Add(comment2);
        _comment.Add(comment3);
    }
    public int NumOfComment()
    {
        int count = 0;
        foreach (Comment comment in _comment)
        {
            count++;
        }
        return count; 
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public string DisplayVideoInformation()
    {
        return $"Tittle: {_title}\nAuthor: {_author}\nDuration:{_length}seconds\nNumber Of Comments: {NumOfComment()}\nComments";
    }
    public string DisplayComments()
    {
        string info = "";
        foreach (Comment comment in _comment)
        {
            info += $"{comment.DisplayComment()}";
        }
        return info;
    }
}