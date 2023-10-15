using System;
using System.Collections.Concurrent;

public class EternalGoal : Goal
{
  // Description
  /*
  Provide for eternal goals that are never complete, but each time the user records them, they gain value each time they complete it.
  */

  // Member Variables
  private int _count;

  // Getters & Setters
  public void SetCount(int count)
  {
    _count = count;
  }
  public int GetCount()
  {
    return _count;
  }
  // Constructors
  public EternalGoal(string name, string description, int points) : base(name, description, points)
  {
    _count = 0;
  }

  // Methods
  public override bool Status()
  {
    return base.Status();
  }
  public override int RecordEvent()
  {
    _count += 1;
    return _points;
  }
  public override string GetDetailString()
  {
    return $"{_name} - {_description} - Completed {_count} times.";
  }
  public override string GetStringRepresentation()
  {
    return $"EternalGoal,{_name},{_description},{_points}";
  }

}