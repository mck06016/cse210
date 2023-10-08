using System;

public class RegularPolygon : Shape
{
  // Member Variables
  private int _side; // Number of Sides
  private double _length; // Length of 1 Side

  // Constructors
  public RegularPolygon(string color, int side, double length) : base(color)
  {
    _side = side;
    _length = length;
    _name = "Regular Polygon";
  }

  // Methods (Getters & Setters)
  public int GetSide()
  {
    return _side;
  }
  public void SetSide(int side)
  {
    _side = side;
  }
  public double GetLength()
  {
    return _length;
  }
  public void SetLength(double length)
  {
    _length = length;
  }

  // Methods
  public override double GetArea()
  {
    return _length * _length * _side / (4 * Math.Tan(180 / _side));
  }

}