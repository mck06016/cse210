using System;

public class Video
{
  // Member Variables
  private string _title;
  private string _author;
  private int _length;  // In Seconds
  public List<Comment> _comments = new List<Comment>();

  // Constructors
  public Video()
  {

  }
  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
  }

  // Methods (Getters & Setters)
  public string GetTitle()
  {
    return _title;
  }
  public string GetAuthor()
  {
    return _author;
  }
  public int GetLength()
  {
    return _length;
  }
  public void SetTitle(string title)
  {
    _title = title;
  }
  public void SetAuthor(string author)
  {
    _author = author;
  }
  public void SetLength(int length)
  {
    _length = length;
  }

  // Methods
  public void DisplayVideo()
  {
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_length} seconds.");
    foreach (Comment comment in _comments)
    {
      comment.DisplayComment();
      Console.WriteLine();
    }
    Console.WriteLine();
  }



}