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

  /* Moved this variable and the GetRandomPrompt to the Activity Parent Class. I had the same exact code in 2 places. The only difference was that there were different lists of prompts. 

  private List<string> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "What are the favorite parts of your job?",
    "What are your favorite things to do with friends or family?",
    "What are your favorite things to do along?",
    "What have been the most interesting things you have learned?",
    "What are things that always make you laugh?",
    "What are your 'Return to' Movies (that you will watch multiple times)",
    "Who are the people who encourage you?",
    "What are your favorite weekend activities?",
    "What are the parts of yourself (personality) that you love?",
  };
*/
  private List<int> usedPrompts = new List<int>();

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
    string prompt = GetRandomPrompt(2);
    Console.WriteLine($" --- {prompt} ---");

    GetListFromUser();

  }
  /*  There was two locations for this code (In Reflection and Listing) - although it is not used in Breathing I wanted to try moving it to the parent class. I added a GetPromptList(int) and GetRandomPrompt(int) to the Activity class and it works as expected. 

    public string GetRandomPrompt()  // Can this be moved to Activity?
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
    */

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
      Console.Write($"{response} - ");
    }
    Console.WriteLine(".");
    Console.WriteLine();
  }


}