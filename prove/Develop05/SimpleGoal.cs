using System;

public class SimpleGoal : Goal
{
  // Description
  /*
  Provide for Simple goals that can be marked complete and the user gains some points.
  */

  // Member Variables
  private bool _isComplete;

  // Getters & Setters
  public void SetIsComplete(bool status)
  {
    _isComplete = status;
  }
  public bool GetIsComplete()
  {
    return _isComplete;
  }

  // Constructors
  public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
  {
    _isComplete = isComplete;
  }

  // Methods
  public override int RecordEvent()
  {
    if (!_isComplete)
    {
      _isComplete = true;
      return _points;
    }
    return 0;
  }
  public override bool Status()
  {
    return GetIsComplete();
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
  }

}