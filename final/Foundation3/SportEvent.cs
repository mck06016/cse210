using System;

public class SportEvent : Event
{
  // Member Variables
  private string _sport;
  private int _expectedPlayTime;
  // Eliminated Unused Getters and Setters
  // Constructors
  public SportEvent(string title, string description, string date, string time, Address address, string sport, int playTime) : base(title, description, date, time, address)
  {
    _event = "Sport";
    _sport = sport;
    _expectedPlayTime = playTime;
  }

  // Methods
  public void FullDetails()
  {
    Console.WriteLine($"Event Type: {_event}");
    StandardDetails();
    Console.WriteLine($"Sport Event: {_sport}");
    Console.WriteLine($"Expected Length if the Game/Match: {_expectedPlayTime}");
  }



}