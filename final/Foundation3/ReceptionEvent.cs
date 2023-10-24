using System;

public class ReceptionEvent : Event
{
  // Member Variables
  private string _rsvpAddress;
  // Eliminated Unused Getters and Setters
  // Constructors
  public ReceptionEvent(string title, string description, string date, string time, Address address, string rsvpAddress) : base(title, description, date, time, address)
  {
    _event = "Reception";
    _rsvpAddress = rsvpAddress;
  }


  // Methods
  public void FullDetails()
  {
    Console.WriteLine($"Event Type: {_event}");
    StandardDetails();
    Console.WriteLine($"RSVP to: {_rsvpAddress}");
  }


}