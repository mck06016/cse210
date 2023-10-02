using System;
using System.Diagnostics;

public class ListingActivity : Activity
{

  /*
   Name = " Listing Activity"

   Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
  
  */

  //Member Variables
  private int _count;
  private List<string> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
  };

  List<int> usedPrompts = new List<int>();

  //Constructors
  public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
  {

  }


  //Methods (Getters & Setters)



  //Methods 
  public void Run()
  {
    Console.Clear();
    Console.WriteLine("List as many responses as you can to the following promot:");
    string prompt = GetRandomPrompt();
    Console.WriteLine($" --- {prompt} ---");

    GetListFromUser();

  }

  public string GetRandomPrompt()  // string
  {
    string prompt = "";

    Random rand = new Random();
    int num;

    do
    {
      num = rand.Next(0, _prompts.Count);
    } while (usedPrompts.Contains(num));

    if (usedPrompts.Count() < _prompts.Count())
    {
      usedPrompts.Add(num);
      prompt = _prompts[num];
    }
    else
    {
      Console.WriteLine("There are no more prompts for today!");
    }
    return prompt;
  }

  public void GetListFromUser() //In tutoring while figuring out the failure of logic in my GetRandom Methods. It was pointed out that we do NOT need to store the list. Jsut return the count. I Included the recollection of the list. And included a print function to print them in a sentence.
  {
    int time = GetDuration();

    var stopwatch = new Stopwatch();
    stopwatch.Start();

    _count = 0;

    List<string> _list = new List<string>();

    while (stopwatch.Elapsed < TimeSpan.FromSeconds(time))
    {
      Console.Write("Response: ");
      string input = Console.ReadLine();
      _list.Add(input);
      _count++;
    }
    Console.WriteLine($"You listed {_count} items!");
    Console.WriteLine();
    foreach (string response in _list)
    {
      Console.Write($"{response}, ");
    }
    Console.WriteLine(".");
    Console.WriteLine();
  }


}