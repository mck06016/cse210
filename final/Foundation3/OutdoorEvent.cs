using System;

public class OutdoorEvent : Event
{
  // Member Variables
  private string _expectedWeather;


  // Getters and Setters
  public void SetWeather(string expectedWeather)
  {
    _expectedWeather = expectedWeather;
  }
  public string GetWeather()
  {
    return _expectedWeather;
  }

  // Constructors
  public OutdoorEvent(string title, string description, string date, string time, Address address, string expectedWeather) : base(title, description, date, time, address)
  {
    _expectedWeather = expectedWeather;
  }

  // Methods
  public void FullDetails()
  {
    Console.WriteLine("Event Type: Outdoor");
    StandardDetails();
    Console.WriteLine($"Expected Weather: {_expectedWeather}");
  }

  public void ShortDescription()
  {
    Console.WriteLine("Event Type: Outdoor");
    Console.WriteLine($"Event Title: {GetTitle()}");
    Console.WriteLine($"Event Date: {GetDate()}");
  }

}