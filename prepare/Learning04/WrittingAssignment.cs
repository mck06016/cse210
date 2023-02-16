public class WrittingAssignment : Assignment
{
  private string _title; 

  public string GetTitle()
  {
    return _title; 
  }

  public WrittingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)  // I did okay until here - - this part mixed me up. and I reviewed the code from the sample solution - - took me another bunch to find the additional text on line 1
  {
    _title = title; 

  }

  public string GetWrittingInformation()
  {

    string studentName = GetStudentName();
    return $"{_title} by {studentName}";
  }
}