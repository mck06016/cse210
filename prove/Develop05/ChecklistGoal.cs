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
  public void SetAmountCompleted(int completed)
  {
    _amountCompleted = completed;
  }
  public int GetAmountCompleted()
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
  public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
    _amountCompleted = 0;
  }


  // Methods
  public override int RecordEvent()
  {
    if (_amountCompleted < _target)
    {
      _amountCompleted++;
      return _points;
    }
    else if (_amountCompleted == _target)
    {
      return _bonus;
    }
    else
    {
      return 0;
    }

  }
  public override bool Status()
  {
    bool complete;
    if (_amountCompleted >= _target)
    {
      complete = true;
    }
    else
    {
      complete = false;
    }
    return complete;
  }
  public override string GetDetailString()
  {
    return $"{_name} - {_description} - Completed {_amountCompleted}/{_target} times.";
  }
  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal,{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
  }


}