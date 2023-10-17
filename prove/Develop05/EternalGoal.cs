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
  public EternalGoal(string name, string description, int points, bool isComplete = false, int amountCompleted = 0) : base(name, description, points)
  {
    _count = amountCompleted;
  }

  // Methods
  public override bool Status()
  {
    return false;
  }
  public override int RecordEvent()
  {
    _count += 1;
    return _points;
  }
  public override string GetDetailString()
  {
    return $"{_name} - {_description} - Completed {_count} times for {_points} points each time.";
  }
  public override string GetStringRepresentation()
  {
    bool isComplete = Status();
    return $"EternalGoal,{_name},{_description},{_points},{isComplete},{_count}";
  }

}