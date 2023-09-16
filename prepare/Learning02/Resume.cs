using System;
using System.Runtime.CompilerServices;

public class Resume
{
  //Member Variables
  public string _firstName = "";
  public string _lastName = "";
  public List<Job> _job = new List<Job>();

  //Methods
  public Resume()
  {

  }

  public void Display()
  {
    Console.WriteLine($"Name: {_firstName} {_lastName}");
    Console.WriteLine("Jobs: ");
    foreach (Job job in _job)
    {
      job.Display();
    }
  }
}