using System;
using System.Diagnostics;

public class ReflectionActivity : Activity
{
  /*
   Name = "Reflection Activity"

   Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."

  */


  //Member Variables
  private List<string> _prompts = new List<string>()
  {
    "Think of a time when you stood up for someone else. ",
    "Think of a time when you did something really difficult. ",
    "Think of a time when you helped someone in need. ",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you felt the spirit. ",
    "Think of a time when you felt loved. ",
    "Think of a time when you wanted something for the benefit of someone else. ",
  };
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

  List<int> usedPrompts = new List<int>();
  List<int> usedQuestions = new List<int>();


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

  public string GetRandomPrompt() //Reused the Prompt.cs code from the Journal Program and cleaned it up.
  {
    string prompt ="";
  
    Random rand = new Random();
    int num = rand.Next(0, _prompts.Count);

    if (usedPrompts.Count() < _prompts.Count())
    {
      if (!usedPrompts.Contains(num))
      {
        usedPrompts.Add(num);
        prompt = _prompts[num];
      }
      else{
        GetRandomPrompt();
      }
    }
    else
    {
      Console.WriteLine("There are no more prompts for today!");
    }
    return prompt;
  }

  public string GetRandomQuestion() 
  {
    string question ="";

    Random rand = new Random();
    int num = rand.Next(0, _questions.Count);

// No Consideration for Duplicates
    question = _questions[num];


/*  // Code is supposed to stop duplicate questions but sometimes I don't get a question.
    if (usedQuestions.Count() < _questions.Count())
    {
      if (!usedQuestions.Contains(num))
      {
        usedQuestions.Add(num);
        question = _questions[num];
      }
      else{
        GetRandomQuestion();
      }
    }
    else
    {
      Console.WriteLine("There are no more questions for today!");
    }
  */  
    return question;
  }

  public void DisplayPrompt()
  {
    Console.WriteLine(GetRandomPrompt());
    Console.Write("Press any key when you are ready to proceed. ");
    Console.ReadLine(); 
  }

  public void DisplayQuestions()
  {
    int time = GetDuration();

    var stopwatch = new Stopwatch();
    stopwatch.Start();

    while (stopwatch.Elapsed < TimeSpan.FromSeconds(time))
    {
      Console.WriteLine(GetRandomQuestion());
      Pause(5); //Short Time used for Testing
      Console.WriteLine();
    }
  }


}