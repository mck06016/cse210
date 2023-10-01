using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class Activity
{

  //Member Variables
  private string _name;
  private string _descritpion;
  private int _duration;


  //Constructors
  public Activity()
  {

  }


  //Methods (Getters & Setters)
  public string GetName()
  {
    return _name;
  }
  public string GetDescription()
  {
    return _descritpion;
  }
  public int GetDuration()
  {
    return _duration;
  }

  public void SetName(string Name)
  {
    _name = Name;
  }
  public void SetDescription(string Description)
  {
    _descritpion = Description;
  }

  //Methods
  public void DisplayStartingMessage()
  {

  }

  public void DisplayEndingMessage()
  {

  }

  public void ShowAnnimate(int Seconds) //Working in standalone test
  {
    var stopwatch = new Stopwatch();
    stopwatch.Start();

    while (stopwatch.Elapsed < TimeSpan.FromSeconds(Seconds))
    {
      Console.Write("*");
      Thread.Sleep(500);
      Console.Write("\b \b");
      Console.Write("~");
    }
  }

  public void ShowCountDown(int Seconds) //Working in standalone test
  {
    int x = Seconds;

    while (x >=0)
    {
      Console.WriteLine(x);
      Thread.Sleep(1000);

      x--;
      
    }
  }
}