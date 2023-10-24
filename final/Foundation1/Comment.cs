using System;

public class Comment
{
  // Member Variables
  private string _name;
  private string _comment;
  // Eliminated Unused Getters and Setters
  // Constructors
  public Comment(string name, string comment)
  {
    _name = name;
    _comment = comment;
  }

  // Methods
  public void DisplayComment()
  {
    Console.WriteLine($"Poster: {_name} - Comment: {_comment}");
  }


}