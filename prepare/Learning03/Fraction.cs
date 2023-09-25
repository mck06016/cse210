public class Fraction
{
  private int _top;

  private int _bottom;

  public Fraction () //Constructor no paramaters
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction (int wholeNumber) //Constructor 1 paramater (numerator) denominator is 1.
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  public Fraction (int top, int bottom) //Constructor 2 parameters top and bottom.
  {
    _top = top;
    _bottom = bottom;
  }

//These were in the class diagram - - 
  public int GetTop()
  {
    return _top;
  }

  public void SetTop(int top)
  {
    _top = top;
  }

  public int GetBottom()
  {
    return _bottom;
  }

  public void SetBottom(int bottom)
  {
    _bottom = bottom;
  }
  
  public string GetFractionString()
  {
    string fraction = $"{_top}/{_bottom}";
    return fraction;
  }

  public double GetDecimalValue()
  {
    return (double) _top / (double) _bottom ;
  }

}