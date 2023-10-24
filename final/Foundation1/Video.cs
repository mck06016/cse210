using System;

public class Video
{
  // Member Variables
  private string _title;
  private string _author;
  private int _length;  // In Seconds
  public List<Comment> _comments = new List<Comment>();
  // Eliminated Unused Getters and Setters
  // Constructors
  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
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
    }
    Console.WriteLine();
  }



}