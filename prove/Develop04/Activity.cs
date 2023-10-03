using System;
using System.Diagnostics;


public class Activity
{

  //Member Variables - Protected Variables needed for derrived classes. 
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
    Pause(8);
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
      CountDown(5);
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

  public void Pause(int Seconds)
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

  public void CountDown(int Seconds)
  {
    int x = Seconds;

    while (x > 0)
    {
      Console.Write(x);
      Thread.Sleep(1000);
      x--;
    }
  }

  public void CountUp(int Seconds)
  {
    int x = 1;

    while (x <= Seconds)
    {
      Console.Write(x);
      Thread.Sleep(1000);
      x++;
    }
  }


  public List<string> GetPromptList(int x)
  {
    List<string> _prompts = new List<string>();
    if (x == 1)
    {
      _prompts.Clear();
      _prompts.Add("Think of a time when you stood up for someone else.");
      _prompts.Add("Think of a time when you did something really difficult.");
      _prompts.Add("Think of a time when you helped someone in need.");
      _prompts.Add("Think of a time when you did something truly selfless.");
      _prompts.Add("Think of a time when you felt the spirit.");
      _prompts.Add("Think of a time when you felt loved.");
      _prompts.Add("Think of a time when you wanted something for the benefit of someone else.");
      _prompts.Add("Think of a time when you did something kind or thoughful for someone.");
      _prompts.Add("Think of a time when you shared your testimony.");
      _prompts.Add("Think of a time when you stood up for something you believed in.");
      _prompts.Add("Think of a time when you didn't get what you wanted, and that was a good thing.");

    }
    else if (x == 2)
    {
      _prompts.Clear();
      _prompts.Add("Who are people that you appreciate?");
      _prompts.Add("What are personal strengths of yours?");
      _prompts.Add("Who are people that you have helped this week?");
      _prompts.Add("When have you felt the Holy Ghost this month?");
      _prompts.Add("Who are some of your personal heroes?");
      _prompts.Add("What are the favorite parts of your job?");
      _prompts.Add("What are your favorite things to do with friends or family?");
      _prompts.Add("What are your favorite things to do along?");
      _prompts.Add("What have been the most interesting things you have learned?");
      _prompts.Add("What are things that always make you laugh?");
      _prompts.Add("What are your 'Return to' Movies (that you will watch multiple times)");
      _prompts.Add("Who are the people who encourage you?");
      _prompts.Add("What are your favorite weekend activities?");
      _prompts.Add("What are the parts of yourself (personality) that you love?");
    }
    return _prompts;
  }

  public string GetRandomPrompt(int x)  // Can this be moved to Activity?
  {
    List<int> _usedPrompts = new List<int>();

    List<string> _prompts = GetPromptList(x);

    string prompt = "";

    Random rand = new Random();
    int num;

    do
    {
      num = rand.Next(0, _prompts.Count);
    } while (_usedPrompts.Contains(num));

    if (_usedPrompts.Count() < _prompts.Count())
    {
      _usedPrompts.Add(num);
      prompt = _prompts[num];
    }
    else
    {
      Console.WriteLine("There are no more prompts for today!");
    }
    return prompt;
  }
}