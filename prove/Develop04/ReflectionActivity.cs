using System;
using System.Diagnostics;

public class ReflectionActivity : Activity
{
  /*
   Name = "Reflection Activity"

   Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."

  */


  //Member Variables
  private List<string> _prompts = new List<string>();
  private List<string> _questions  = new List<string>();

  List<int> usedPrompts = new List<int>();
  List<int> usedQuestions = new List<int>();


  //Constructors
  public ReflectionActivity ()
  {

  }

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

  public string GetRandomPrompt() //Reused the Prompt.cs code from the Journal Program
  {
    string prompt ="";
    _prompts.Add("Think of a time when you stood up for someone else. ");
    _prompts.Add("Think of a time when you did something really difficult. ");
    _prompts.Add("Think of a time when you helped someone in need. ");
    _prompts.Add("Think of a time when you did something truly selfless.");
    _prompts.Add("Think of a time when you felt the spirit. ");
    _prompts.Add("Think of a time when you felt loved. ");
    _prompts.Add("Think of a time when you wanted something for the benefit of someone else. ");

    //int lengthPrompts = prompts.Count;
    Random rand = new Random();
    int num = rand.Next(0, _prompts.Count);

    if (usedPrompts.Count() < _prompts.Count())  //I can manually enter 50 or the number of prompts I have.
    {
      if (!usedPrompts.Contains(num))
      {
        //Console.WriteLine($"{num +1}.{prompts[num]}");
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
    _questions.Add("Why was this experience meaningful to you?");
    _questions.Add("Have you ever done anything like this before?");
    _questions.Add("How did you get started?");
    _questions.Add("How did you feel when it was complete?");
    _questions.Add("What made this time different than other times when you were not as successful?");
    _questions.Add("What is your favorite thing about this experience?");
    _questions.Add("What could you learn from this experience that applies to other situations?");
    _questions.Add("What did you learn about yourself through this experience?");
    _questions.Add("How can you keep this experience in mind in the future?");

    //int lengthPrompts = prompts.Count;
    Random rand = new Random();
    int num = rand.Next(0, _questions.Count);

    if (usedQuestions.Count() < _questions.Count())  //I can manually enter 50 or the number of prompts I have.
    {
      if (!usedQuestions.Contains(num))
      {
        //Console.WriteLine($"{num +1}.{prompts[num]}");
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
      GetRandomQuestion();
      Pause(5);
    }
  }


}