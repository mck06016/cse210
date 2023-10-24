using System;

public class Exercise
{
  /*
  I am from Canada so opting to complete my program for Kilometers. (PS - I know that BYU-I is in the US but come on there are only 4 countries out of 195 that use the Mile for measurement. 191 use Metric.)
  */

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