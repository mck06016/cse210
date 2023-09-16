using System;

public class Job 
{
  //Member Variables
  public string _company = "";
  public string _jobTitle = "";
  public int _startYear;
  public int _endYear;

  //Methods
  public Job()
  {

  }

  public void Display()
  {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
  }

}