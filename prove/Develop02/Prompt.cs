using System;

public class Prompt
{
    List<int> usedPrompts = new List<int>();

    public string GetPrompts()
    {
      string prompt ="";
      List<string> prompts = new List<string>()
      {
        "Write about your name. Where did it come from? What does it mean?",
        "When and where were you born?",
        "Write about your mom. What would you want people to know?",
        "Write about your dad. What would you want people to know?",
        "Do you have any siblings? Write about them.",
        "Where did you grow up? What do you remember from that place?",
        "Think about your house growing up. What was it like?",
        "What was your childhood bedroom like?",
        "What was your favorite activity as a child?",
        "What was your favorite place as a child?",
        "Who were your friends as a child?",
        "Did you travel as a child? What were your favorite places to visit?",
        "What did a typical day look like as a child?",
        "What did a typical day look like as a teen?",
        "What was high school like for you?",
        "What world events were significant to you as a child?",
        "Write about your grandparents.",
        "Write about your aunts.",
        "Write about your uncles.",
        "Write about your cousins.",
        "Write about your early school memories.",
        "What was your favorite subject in school?",
        "Who was your favorite teacher as a child?",
        "Did you move as a child? Write about it.",
        "Who taught you to drive?",
        "What was your favorite food as a child?",
        "Write about your most memorable birthday",
        "How did you typically celebrate your birthday?",
        "Write about your favorite holiday memory.",
        "What was the hardest part about growing up?",
        "What was the best part about growing up?",
        "When did you first leave home? Write about that experience.",
        "What did your parents do for work?",
        "What was your first job?",
        "What is your favorite family story?",
        "Are there any funny stories that have been passed down through the generations? Write one of them.",
        "What were you most proud of as a child?",
        "What did you want to be/do when you grew up? Did you become or do it?",
        "Who inspired you as you matured?",
        "What job has been your favorite?",
        "What was the best part of your 20s?",
        "What was the best part of your 30s?",
        "Are you in a relationship? How did you meet your significant other?",
        "Did you have any boyfriends/girlfriends as a youth? Write about them.",
        "Do you have kids? Write about them",
        "What are you most proud of as an adult?",
        "Where is the most fascinating place you’ve visited?",
        "What is one thing about today that you never want to forget?",
        "What item will you cross of your bucket list next?",
        "What advice would you give your younger self?",
      };

      //int lengthPrompts = prompts.Count;
      Random rand = new Random();
      int num = rand.Next(0, prompts.Count);

      if (usedPrompts.Count() < prompts.Count())  //I can manually enter 50 or the number of prompts I have.
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