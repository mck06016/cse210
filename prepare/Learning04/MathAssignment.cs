using System;

public class MathAssignment:Assignment
{
  //Member Variables
  private string _textbookSection;
  private string _problems;


  //Constructors
  public MathAssignment(string StudentName, string Topic, string TextbookSection, string Problems):base(StudentName, Topic)
  {
    _textbookSection = TextbookSection;
    _problems = Problems;
  }


  //Methods (Getters & Setters)
  public string GetTextbookSection()
  {
    return _textbookSection;
  }
  public string GetProblems()
  {
    return _problems;
  }

  //Methods
  public string HomeworkList()
  {
    return _textbookSection + " " + _problems;
  }
}