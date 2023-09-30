using System;

public class Assignment 
{
  //MemberVariables

  private string _studentName;
  private string _topic;

//Constructors
  public Assignment(string StudentName, string Topic)
  {
    _studentName = StudentName;
    _topic = Topic;
  }

  //Methods (Getters & Setters)
  public string GetStudentName()
  {
    return _studentName;
  }

  public string GetTopic()
  {
    return _topic;
  }


  //Methods
  public string Summary()
  {
    return _studentName + " - " + _topic;
  }

}