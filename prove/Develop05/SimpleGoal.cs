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
  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
    _isComplete = false;
  }

  // Methods



}