using System;

public class SportEvent : Event
{
  // Member Variables
  private string _sport;
  private int _expectedPlayTime;


  // Getters and Setters
  public void SetPlayTime(int playTime)
  {
    _expectedPlayTime = playTime;
  }
  public int GetPlayTime()
  {
    return _expectedPlayTime;
  }

  // Constructors
  public SportEvent(string title, string description, string date, string time, Address address, string sport, int playTime) : base(title, description, date, time, address)
  {
    _sport = sport;
    _expectedPlayTime = playTime;
  }

  // Methods
  public void FullDetails()
  {
    Console.WriteLine("Event Type: Sport");
    StandardDetails();
    Console.WriteLine($"Sport Event: {_sport}");
    Console.WriteLine($"Expected Length if the Game/Match: {_expectedPlayTime}");
  }

  public void ShortDescription()
  {
    Console.WriteLine("Event Type: Sport");
    Console.WriteLine($"Event Title: {GetTitle()}");
    Console.WriteLine($"Event Date: {GetDate()}");
  }

}