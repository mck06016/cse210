using System;

public class Triangle : Shape
{
  // Member Variables
  private double _base;
  private double _height;

  // Constructors
  public Triangle(string color, double length, double height) : base(color)
  {
    _base = length;
    _height = height;
    _name = "Triangle";
  }

  // Methods (Getters & Setters)
  public double GetBase()
  {
    return _base;
  }
  public void SetBase(double length)
  {
    _base = length;
  }
  public double GetHeight()
  {
    return _height;
  }
  public void SetHeight(double height)
  {
    _height = height;
  }

  // Methods
  public override double GetArea()
  {
    return 0.5 * _base * _height;
  }

}