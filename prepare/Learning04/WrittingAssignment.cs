using System;

public class WrittingAssignment:Assignment
{
  //Member Variables
  private string _title;

  //Constructors
  public WrittingAssignment(string StudentName, string Topic, string Title):base(StudentName, Topic)
  {
    _title = Title;
  }

  //Methods (Getters & Setters)
  public string GetTitle()
  {
    return _title;
  }

  //Methods
  public string WritingInformation()
  {
    string studentName = GetStudentName();
    return $"{_title} by {studentName}";
  }
}