using System;

public class StationaryBicycle : Exercise
{
  // Member Variables
  public float _speed;

  // Methods (Getters and Setters)
  public void SetSpeed(float speed)
  {
    _speed = speed;
  }
  public float GetSpeed()
  {
    return _speed;
  }

  // Constructors
  public StationaryBicycle(DateTime date, int length, float speed) : base(date, length)
  {
    _speed = speed;
  }


  // Methods
  public override float Distance()
  {
    int length = GetLength();
    float distance = (_speed * length) / 60;
    return distance;
  }
  public override float Speed()
  {
    return _speed;
  }
  public override float Pace()
  {
    float pace = 60 / _speed;
    return pace;  // min/km - - 1 KM/H  = 60 Min/KM
  }
  public override void GetSummary() // change void to string.
  {

  }


}