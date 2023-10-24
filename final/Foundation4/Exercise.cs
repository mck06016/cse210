using System;

public class Exercise
{
  // Member Variables
  protected string _date;
  protected int _length;
  protected string _name;

  // Methods (Getters and Setters)
  // Eliminated Unused Getters and Setters
  public string GetDate()
  {
    return _date;
  }
  public int GetLength()
  {
    return _length;
  }

  // Constructors
  public Exercise(string date, int length)
  {
    _date = date;
    _length = length;
  }

  // Methods
  public virtual float Distance()
  {
    return 0;
  }
  public virtual float Speed()
  {
    return 0;
  }
  public virtual float Pace()
  {
    return 0;
  }
  public string GetSummary()
  {
    string date = GetDate();
    float distance = Distance();
    float speed = Speed();
    float pace = Pace();
    return $"{date} {_name} ({_length} min): Distance: {distance:0.00} km, Speed: {speed:0.00} kph, Pace: {pace:0.00} min/km";
  }


}