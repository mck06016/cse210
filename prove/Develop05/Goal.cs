using System;

public class Goal
{
  // Description


  // Member Variables
  private string _name;
  private string _descritpion;
  private int _points;

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
    _descritpion = description;
  }
  public string GetDescription()
  {
    return _descritpion;
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
    _descritpion = description;
    _points = points;

  }

  // Methods
  public virtual void RecordEvent()
  {

  }
  public virtual bool IsComplete()
  {
    return false;
  }



}