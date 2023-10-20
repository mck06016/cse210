using System;

public class Swimming : Exercise
{
  // Member Variables
  public int _laps;

  // Methods (Getters and Setters)
  public void SetLaps(int laps)
  {
    _laps = laps;
  }
  public int GetLaps()
  {
    return _laps;
  }

  // Constructors
  public Swimming(DateTime date, int length, int laps) : base(date, length)
  {
    _laps = laps;
  }

  // Methods
  public override float Distance() // change void to float.
  {
    float distance = _laps * 50 / 1000;
    return distance;
  }
  public override float Speed() // change void to float.
  {
    float distance = Distance();
    int length = GetLength();
    float speed = (distance / length) * 60;
    return speed;
  }
  public override float Pace() // change void to float.
  {
    float speed = Speed();
    float pace = 60 / speed;
    return pace;
  }
  public override void GetSummary() // change void to string.
  {

  }

}