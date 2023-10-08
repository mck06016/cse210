using System;

public class Square : Shape
{
  // Member Variables
  private double _side;

  // Constructors
  public Square(string color, double side) : base(color)
  {
    _side = side;
    _name = "Square";
  }

  // Methods (Getters & Setters)
  public double GetSide()
  {
    return _side;
  }
  public void SetSide(double side)
  {
    _side = side;
  }

  // Methods
  public override double GetArea()
  {
    return _side * _side;
  }

}