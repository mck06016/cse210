using System; 

public class Comment
{
  // Member Variables
  private string _name;
  private string _comment;

  // Constructors
  public Comment()
  {

  }
  public Comment(string name, string comment)
  {
    _name = name;
    _comment = comment;
  }
  // Methods (Getters & Setters)
  public string GetPoster()
  {
    return _name;
  }

  public string GetComment()
  {
    return _comment;
  }

  public void SetPoster(string name)
  {
    _name = name;
  }

  public void SetComment(string comment)
  {
    _comment = comment;
  }

  // Methods
  public void DisplayComment()
  {
    Console.WriteLine($"Poster: {_name} - Comment: {_comment}");
  }


}