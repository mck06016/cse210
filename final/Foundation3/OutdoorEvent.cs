using System;

public class OutdoorEvent : Event
{
  // Member Variables
  private string _expectedWeather;
  // Eliminated Unused Getters and Setters
  // Constructors
  public OutdoorEvent(string title, string description, string date, string time, Address address, string expectedWeather) : base(title, description, date, time, address)
  {
    _event = "Outdoor";
    _expectedWeather = expectedWeather;
  }

  // Methods
  public void FullDetails()
  {
    Console.WriteLine($"Event Type: {_event}");
    StandardDetails();
    Console.WriteLine($"Expected Weather: {_expectedWeather}");
  }
}