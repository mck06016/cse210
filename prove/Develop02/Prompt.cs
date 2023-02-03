using System;

public class Prompt
{
    List<int> usedPrompts = new List<int>();

    public string GetPrompts()
    {
      string prompt ="";
      List<string> prompts = new List<string>()
      {
        //https://dreamdashjournal.com/30-daily-journal-prompts-to-start-writing-free-pdf-printable-included/#:~:text=30%20Daily%20Journal%20Prompts%20to%20Start%20Writing%201,10%20things%20you%20love%20about%20yourself.%20More%20items
        "What are you most excited about for today?",
        "Who makes you feel happiest in life and why?",
        "What are you most grateful for in your life?",
        "Write about the best day you’ve had recently.",
        "What challenges have you overcome in life?",
        "What are you most proud of?",
        "Write about one of your happiest memories.",
        "List 10 things you love about yourself.",
        "What are your blessings in life?",
        "How can you make the world a better place?",
        "What do you want to improve in your life?",
        "List 5 short-term goals and 10 long-term goals.",
        "Where would you like to travel and where would you stay?",
        "What adventures would you like to have?",
        "List some material possessions would you like to own.",
        "Jot down a list of books to read, movies to watch, or topics to learn about.",
        "What is your dream job?",
        "Who would you like to meet?",
        "What excites you about the future?",
        "What do you miss most about the past?",
        "Describe your perfect day in detail.",
        "What are some new hobbies you’d like to try?",
        "Who or what inspires you?",
        "What are your strengths and weaknesses?",
        "What are the most valuable life lessons you have learned?",
        "How would you describe yourself to someone you’ve never met?",
        "What makes you laugh the most?",
        "What are your spiritual beliefs?",
        "Describe your ideal lifestyle.",
        "What advice would you give your younger self?",
      };
      //I had trouble with double prompts showing up (even when I had jsut 2-3 prompts which is why I went to so many prompts.) The following code was done with help from our initial group meeting. 

      Random rand = new Random();
      int num = rand.Next(0, prompts.Count);

      if (usedPrompts.Count() < 30)  //30 because that is the numebr of prompts I have.
      {
        if (!usedPrompts.Contains(num))
        {
          //Console.WriteLine($"{num +1}.{prompts[num]}");
          usedPrompts.Add(num);
          prompt = prompts[num];
        }
        else{
          GetPrompts();
        }
      }
      else
      {
        Console.WriteLine("There are no more prompts for today!");
      }
      return prompt;
    }
}