using System;
using System.Diagnostics;


public class Activity
{

  //Member Variables
  protected string _name;
  protected string _descritpion;
  protected int _duration;


  //Constructors

  public Activity()
  {

  }
  public Activity(string activityName, string activityDescription)
  {
    _name = activityName;
    _descritpion = activityDescription;
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
    Console.WriteLine($"Welcome to the {_name}");
    Pause(1);
    Console.WriteLine();
    Console.WriteLine($"{_descritpion}");
    Pause(1); //Short Time used for Testing
    Console.WriteLine();
    Console.Write($"How long would you like for this {_name} session (in seconds): ");
    string entry = Console.ReadLine();
    bool result = int.TryParse(entry, out _duration);
    if (result == false)
    {
      Console.Clear();
      Console.WriteLine("Not a valid number entry.");
    }
    else
    {
      Console.Clear();
      Console.WriteLine($"The {_name} will begin in 5 seconds, and will run for {_duration} seconds.");
      Console.WriteLine();
      Console.WriteLine("Get Ready ...");
      CountDown(1); //Short Time used for Testing
      Console.Clear();
      Console.WriteLine("Let's begin ... ");
      Console.Write("Press any key to initiate the activity. ");
      Console.ReadLine();
    }
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine($"Well Done !");
    Console.WriteLine();
    Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
    Pause(5);
  }

  public void Pause(int Seconds) //Working in standalone test
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

  public void Spinner(int Seconds)
  {
    var stopwatch = new Stopwatch();
    stopwatch.Start();

    while (stopwatch.Elapsed < TimeSpan.FromSeconds(Seconds))
    {
      Console.Write("-");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("\\");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("|");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("/");
      Thread.Sleep(250);
      Console.Write("\b \b");
    }
  }

  public void CountDown(int Seconds) //Working in standalone test
  {
    int x = Seconds;

    while (x > 0)
    {
      Console.WriteLine(x);
      Thread.Sleep(1000);
      x--;
    }
  }

  public void CountUp(int Seconds)
  {
    int x = 1;

    while (x <= Seconds)
    {
      Console.WriteLine(x);
      Thread.Sleep(1000);
      x++;
    }
  }
}