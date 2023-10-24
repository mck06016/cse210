using System;

public class Event
{
  // Member Variables
  private string _title;
  private string _description;
  private string _date;
  private string _time;
  protected string _event;
  Address _address;

  // Getters and Setters
  public string GetTitle()
  {
    return _title;
  }
  public string GetDate()
  {
    return _date;
  }
  // Eliminated Unused Getters and Setters
  // Constructors
  public Event(string title, string description, string date, string time, Address address)
  {
    _title = title;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
  }

  // Methods
  public void ShortDescription()
  {
    Console.WriteLine($"Event Type: {_event}");
    Console.WriteLine($"Event Title: {GetTitle()}");
    Console.WriteLine($"Event Date: {GetDate()}");
  }
  public void StandardDetails()
  {
    Console.WriteLine($"Event Title: {_title}");
    Console.WriteLine($"Event Description: {_description}");
    Console.WriteLine($"Event Location: {_address.FormattedAddress()}");
    Console.WriteLine($"Event Date: {_date}");
    Console.WriteLine($"Event Time: {_time}");
  }
}