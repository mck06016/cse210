using System;

public class Event
{
  // Member Variables
  private string _title;
  private string _description;
  private string _date;
  private string _time;
  Address _address;

  // Getters and Setters
  public void SetTitle(string title)
  {
    _title = title;
  }
  public string GetTitle()
  {
    return _title;
  }
  public void SetDescription(string description)
  {
    _description = description;
  }
  public string GetDescription()
  {
    return _description;
  }
  public void SetDate(string date)
  {
    _date = date;
  }
  public string GetDate()
  {
    return _date;
  }
  public void SetTime(string time)
  {
    _time = time;
  }
  public string GetTime()
  {
    return _time;
  }

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
  public void StandardDetails()
  {
    Console.WriteLine($"Event Title: {_title}");
    Console.WriteLine($"Event Description: {_description}");
    Console.WriteLine($"Event Location: {_address.FormattedAddress()}");
    Console.WriteLine($"Event Date: {_date}");
    Console.WriteLine($"Event Time: {_time}");
  }

}