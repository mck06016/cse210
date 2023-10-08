using System;

public class Circle : Shape
{
  // Member Variables
  private double _radius;

  // Constructors
  public Circle(string color, double radius) : base(color)
  {
    _radius = radius;
    _name = "Circle";
  }

  // Methods (Getters & Setters)
  public double GetRadius()
  {
    return _radius;
  }
  public void SetRadius(double radius)
  {
    _radius = radius;
  }

  // Methods
  public override double GetArea()
  {
    return _radius * _radius * Math.PI;
  }

}