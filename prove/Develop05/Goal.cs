using System;
using System.Dynamic;

public class Goal
{
  // Description


  // Member Variables
  protected string _name;
  protected string _description;
  protected int _points;

  // Getters & Setters
  public void SetName(string name)
  {
    _name = name;
  }
  public string GetName()
  {
    return _name;
  }
  public void SetDescription(string description)
  {
    _description = description;
  }
  public string GetDescription()
  {
    return _description;
  }
  public void SetPoints(int points)
  {
    _points = points;
  }
  public int GetPoints()
  {
    return _points;
  }

  // Constructors
  public Goal(string name, string description, int points)
  {
    _name = name;
    _description = description;
    _points = points;

  }

  // Methods
  public virtual int RecordEvent()
  {
    return 0; // Specific to each type of Goal
  }
  public virtual bool IsComplete()
  {
    // Specific to each type of Goal
    return false; // Default value is not completed.
  }
  public virtual bool Status()
  {
    return false;
  }
  public virtual string GetNameString()
  {
    return $"{_name}";
  }
  public virtual string GetDetailString()
  {
    return $"{_name} - {_description} - For {_points} points.";
  }

  public virtual string GetStringRepresentation()
  {
    // Specific to each Goal type
    return string.Empty;
  }



}