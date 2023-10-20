using System;

public class LectureEvent : Event
{
  // Member Variables
  private string _speaker;
  private int _capacity;


  // Getters and Setters
  public void SetSpeaker(string speaker)
  {
    _speaker = speaker;
  }
  public string GetSpeaker()
  {
    return _speaker;
  }
  public void SetCapacity(int capacity)
  {
    _capacity = capacity;
  }
  public int GetCapacity()
  {
    return _capacity;
  }
  // Constructors
  public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
  {
    _speaker = speaker;
    _capacity = capacity;
  }


  // Methods
  public void FullDetails()
  {
    Console.WriteLine("Event Type: Lecture");
    StandardDetails();
    Console.WriteLine($"Speaker: {_speaker}");
    Console.WriteLine($"The venue capacity is: {_capacity}");
  }

  public void ShortDescription()
  {
    Console.WriteLine("Event Type: Lecture");
    Console.WriteLine($"Event Title: {GetTitle()}");
    Console.WriteLine($"Event Date: {GetDate()}");
  }

}