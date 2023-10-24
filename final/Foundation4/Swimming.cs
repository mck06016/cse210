using System;

public class Swimming : Exercise
{
  // Member Variables
  public int _laps;
  // Eliminated Unused Getters and Setters
  // Constructors
  public Swimming(string date, int length, int laps) : base(date, length)
  {
    _name = "Swimming";
    _laps = laps;
  }

  // Methods
  public override float Distance()
  {
    float distance = _laps * 50 / 1000;
    return distance;
  }
  public override float Speed()
  {
    float distance = Distance();
    int length = GetLength();
    float speed = (distance / length) * 60;
    return speed;
  }
  public override float Pace()
  {
    float speed = Speed();
    float pace = 60 / speed;
    return pace;
  }

}