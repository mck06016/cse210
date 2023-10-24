using System;

public class LectureEvent : Event
{
  // Member Variables
  private string _speaker;
  private int _capacity;
  // Eliminated Unused Getters and Setters
  // Constructors
  public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
  {
    _event = "Lecture";
    _speaker = speaker;
    _capacity = capacity;
  }

  // Methods
  public void FullDetails()
  {
    Console.WriteLine($"Event Type: {_event}");
    StandardDetails();
    Console.WriteLine($"Speaker: {_speaker}");
    Console.WriteLine($"The venue capacity is: {_capacity}");
  }



}