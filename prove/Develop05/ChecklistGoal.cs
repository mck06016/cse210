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
  private bool _isComplete;

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
  public ChecklistGoal(string name, string description, int points, bool isComplete, int amountCompleted, int target, int bonus) : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
    _amountCompleted = amountCompleted;
    _isComplete = isComplete;
    
  }


  // Methods
  public override int RecordEvent()
  {
    if (_amountCompleted < _target)
    {
      _amountCompleted+=1;
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
    if (_amountCompleted >= _target)
    {
      _isComplete = true;
    }
    else
    {
      _isComplete = false;
    }
    return _isComplete;
  }
  public override string GetDetailString()
  {
    return $"{_name} - {_description} - Completed {_amountCompleted}/{_target} times for {_points} points each time. When Complete {_bonus} points bonus.";
  }
  public override string GetStringRepresentation()
  {
    bool isComplete = Status();
    return $"ChecklistGoal,{_name},{_description},{_points},{_isComplete},{_amountCompleted},{_target},{_bonus}";
  }


}