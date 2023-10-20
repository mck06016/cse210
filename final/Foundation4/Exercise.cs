using System;

public class Exercise
{
  /*
  I am from Canada so opting to complete my program for Kilometers. (PS - I know that BYU-I is in the US but come on there are only 4 countries out of 195 that use the Mile for measurement. 191 use Metric.)
  */

  // Member Variables
  protected DateTime _date = DateTime.Now;
  protected int _length;  // Changed from design to reflect time in minutes.


  // Methods (Getters and Setters)
  public void SetDate(DateTime date)
  {
    _date = date;
  }
  public DateTime GetDate()
  {
    return _date;
  }
  public void SetLength(int length)
  {
    _length = length;
  }
  public int GetLength()
  {
    return _length;
  }

  // Constructors
  public Exercise(DateTime date, int length)
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
  public virtual void GetSummary() // change void to string.
  {

  }


}