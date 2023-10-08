using System;

public class Shape
{
  // Member Variables
  private string _color;
  protected string _name;

  // Constructors
  public Shape(string color)
  {
    _color = color;

  }

  // Methods (Getters & Setters)
  public string GetColor()
  {
    return _color;
  }
  public void SetColor(string color)
  {
    _color = color;
  }

  public string GetName()
  {
    return _name;
  }
  // Methods
  public virtual double GetArea()
  {
    return 0;
  }

}