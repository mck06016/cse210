using System;

public class ChecklistGoal : Goal
{
  // Description
  /*
  Provide for a checklist goal that may be accomplished a certain number of times to be completed. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus. 
  */

  // Member Variables
  private int _target;
  private int _amountCompleted;
  private int _bonus;

  // Getters & Setters
  public void SetTarget(int target)
  {
    _target = target;
  }
  public int GetTarget()
  {
    return _target;
  }
  public void SetAmmountCompleted(int completed)
  {
    _amountCompleted = completed;
  }
  public int GetAmmountCompleted()
  {
    return _amountCompleted;
  }
  public void SetBonus(int bonus)
  {
    _bonus = bonus;
  }
  public int GetBonus()
  {
    return _bonus;
  }

  // Constructors
  public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
  }


  // Methods



}