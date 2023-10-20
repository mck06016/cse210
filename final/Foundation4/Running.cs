using System;

public class Running : Exercise
{
  // Member Variables
  private float _distance;

  // Methods (Getters and Setters)
  public void SetDistance(float distance)
  {
    _distance = distance;
  }
  public float GetDistance()
  {
    return _distance;
  }


  // Constructors
  public Running(DateTime date, int length, float distance) : base(date, length)
  {
    _distance = distance;
  }


  // Methods
  public override float Distance() // change void to float.
  {
    return _distance;
  }
  public override float Speed() // change void to float.
  {
    // km/hour
    int length = GetLength();
    float speed = (_distance / length) * 60;

    return speed;
  }
  public override float Pace() // change void to float.
  {
    int length = GetLength();
    float pace = length / _distance;
    return pace;
  }
  public override void GetSummary() // change void to string.
  {

  }

}