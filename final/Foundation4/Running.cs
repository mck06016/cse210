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
  public Running(string date, int length, float distance) : base(date, length)
  {
    _name = "Running";
    _distance = distance;
  }

  // Methods
  public override float Distance() 
  {
    return _distance;
  }
  public override float Speed() 
  {
    // km/hour
    int length = GetLength();
    float speed = (_distance / length) * 60;

    return speed;
  }
  public override float Pace() 
  {
    int length = GetLength();
    float pace = length / _distance;
    return pace;
  }


}