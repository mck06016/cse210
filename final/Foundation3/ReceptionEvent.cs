using System;

public class ReceptionEvent : Event
{
  // Member Variables
  private string _rsvpAddress;


  // Getters and Setters
  public void SetRSVPAddress(string rsvpAddress)
  {
    _rsvpAddress = rsvpAddress;
  }
  public string GetRSVPAddress()
  {
    return _rsvpAddress;
  }

  // Constructors
  public ReceptionEvent(string title, string description, string date, string time, Address address, string rsvpAddress) : base(title, description, date, time, address)
  {
    _rsvpAddress = rsvpAddress;
  }


  // Methods
  public void FullDetails()
  {
    Console.WriteLine("Event Type: Reception");
    StandardDetails();
    Console.WriteLine($"RSVP to: {_rsvpAddress}");
  }

  public void ShortDescription()
  {
    Console.WriteLine("Event Type: Reception");
    Console.WriteLine($"Event Title: {GetTitle()}");
    Console.WriteLine($"Event Date: {GetDate()}");
  }

}