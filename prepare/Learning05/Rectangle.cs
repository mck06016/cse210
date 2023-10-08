using System;

public class Rectangle : Shape
{
  // Member Variables
  private double _length;
  private double _width;

  // Constructors
  public Rectangle(string color, double length, double width) : base(color)
  {
    _length = length;
    _width = width;
    _name = "Rectangle";
  }

  // Methods (Getters & Setters)
  public double GetLength()
  {
    return _length;
  }
  public void SetLength(double length)
  {
    _length = length;
  }
  public double GetWidth()
  {
    return _width;
  }
  public void SetWidth(double width)
  {
    _width = width;
  }

  // Methods
  public override double GetArea()
  {
    return _length * _width;
  }

}