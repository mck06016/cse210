using System;
using System.Diagnostics;

public class ReflectionActivity : Activity
{
  /*
   Name = "Reflection Activity"

   Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."

  */


  //Member Variables
  /*
  private List<string> _prompts = new List<string>()
  {
    "Think of a time when you stood up for someone else. ",
    "Think of a time when you did something really difficult. ",
    "Think of a time when you helped someone in need. ",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you felt the spirit. ",
    "Think of a time when you felt loved. ",
    "Think of a time when you wanted something for the benefit of someone else. ",
    "Think of a time when you did something kind or thoughful for someone.",
    "Think of a time when you shared your testimony.",
    "Think of a time when you stood up for something you believed in.",
    "Think of a time when you didn't get what you wanted, and that was a good thing.",
  };
  */
  private List<string> _questions = new List<string>()
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
  };

  private List<int> usedPrompts = new List<int>();
  private List<int> usedQuestions = new List<int>();


  //Constructors
  public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
  {

  }

  //Methods (Getters & Setters)



  //Methods 
  public void Run()
  {
    DisplayPrompt();
    DisplayQuestions();
  }

  /* There was two locations for this code (In Reflection and Listing) - although it is not used in Breathing I wanted to try moving it to the parent class. I added a GetPromptList(int) and GetRandomPrompt(int) to the Activity class and it works as expected. 

    public string GetRandomPrompt()  
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

  public string GetRandomQuestion()
  {
    string question = "";
    int num;
    Random rand = new Random();

    do
    {
      num = rand.Next(0, _questions.Count);
    } while (usedQuestions.Contains(num) && usedQuestions.Count < _questions.Count);

    if (usedQuestions.Count < _questions.Count)
    {
      usedQuestions.Add(num);
      question = _questions[num];
    }
    else
    {
      return "X";
    }

    return question;
  }

  public void DisplayPrompt()
  {
    Console.WriteLine();
    Console.WriteLine(GetRandomPrompt(1));
    Console.Write("Press any key when you are ready to proceed. ");
    Console.ReadLine();
  }

  public void DisplayQuestions()
  {
    Console.WriteLine();
    int time = GetDuration();

    var stopwatch = new Stopwatch();
    stopwatch.Start();

    while (stopwatch.Elapsed < TimeSpan.FromSeconds(time))
    {
      string question = GetRandomQuestion();
      if (question == "X")
      {
        Console.WriteLine("There are no more questions for today!");
        break;
      }
      else
      {
        Console.Write($"{question} ");
        Spinner(10);  // Time to ponder each questionn - I found 5 seconds too short and 15 seconds too long.
      }

      //Pause(5); // I like the spinner at the end of the line better then the Pause Visual. 
      Console.WriteLine();
    }
  }
}