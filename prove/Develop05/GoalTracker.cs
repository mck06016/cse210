using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class GoalTracker
{
  // Description


  // Member Variables
  private List<Goal> _goals;
  private int _score;
  private string _name;

  // Getters & Setters
  public void SetScore(int score)
  {
    _score = score;
  }
  public int GetScore()
  {
    return _score;
  }
  public void SetName(string name)
  {
    _name = name;
  }



  // Constructors
  public GoalTracker()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  // Methods
  public void DisplayPlayerScore()
  {
    Console.WriteLine($"Player Score: {_score}");
  }
  public void DisplayPlayerInfo()
  {

    Console.WriteLine($"{_name} Score: {_score}");
  }

  public void ListGoalsNames()  //WHY WONT YOU WORK
  {
    Console.WriteLine("List of Goals: ");
    foreach (var goal in _goals)
    {
      string status;
      if (goal.Status())
      {
        status = "X";
      }
      else
      {
        status = " ";
      }

      Console.Write($"{_goals.IndexOf(goal) + 1}. [{status}] ");
      string goalName = goal.GetNameString();
      Console.WriteLine($"{goalName}");
    }
  }
  public void ListGoalsDetails()
  {
    Console.WriteLine("List of Goals: ");
    foreach (var goal in _goals)
    {
      string status;
      if (goal.Status())
      {
        status = "X";
      }
      else
      {
        status = " ";
      }

      Console.Write($"{_goals.IndexOf(goal) + 1}. [{status}] ");
      string goalDetails = goal.GetDetailString();
      Console.WriteLine($"{goalDetails}");
    }
  }

  public void GoalMenu()
  {
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Please enter the number of the Goal Type you would like to create: ");

  }

  public string GoalType()
  {
    GoalMenu();
    var response = Console.ReadLine();
    var choice = int.Parse(response);
    string type;

    switch (choice)
    {
      case 1:
        type = "SimpleGoal";
        return type;
      case 2:
        type = "EternalGoal";
        return type;
      case 3:
        type = "ChecklistGoal";
        return type;

      default:
        Console.WriteLine("Not a valid entry");
        return "InvalidGoal";

    }

  }

  public void CreateGoal(string goalType, string name, string description, int points, int target = 0, int bonus = 0, bool isComplete = false)
  {
    Goal newGoal;

    switch (goalType)
    {
      case "SimpleGoal":
        newGoal = new SimpleGoal(name, description, points, isComplete);
        break;
      case "EternalGoal":
        newGoal = new EternalGoal(name, description, points);
        break;
      case "ChecklistGoal":
        newGoal = new ChecklistGoal(name, description, points, target, bonus);
        break;
      default:
        Console.WriteLine("Invalid goal type.");
        return;
    }

    _goals.Add(newGoal);

  }
  // Method to Select a Goal

  public void RecordEvent(int goalIndex)
  {
    if (goalIndex >= 0 && goalIndex < _goals.Count)
    {
      var goal = _goals[goalIndex];
      goal.RecordEvent();
      _score = _score + goal.RecordEvent();
    }
    else
    {
      Console.WriteLine("Invalid Goal Selection.");
    }
  }

  public void SaveGoal(string fileName)
  {
    foreach (Goal goal in _goals)
    {
      using (StreamWriter file = new StreamWriter(fileName, append: true))
      {
        file.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals(string fileName)
  {
    if (File.Exists(fileName))
    {
      _goals.Clear();
      using (StreamReader reader = new StreamReader(fileName))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          string[] parts = line.Split(",");
          if (parts.Length >= 3)
          {
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            int target = 0;
            int bonus = 0;
            bool isComplete = false;

            if (parts.Length > 4)
            {
              switch (goalType)
              {
                case "SimpleGoal":
                  isComplete = bool.Parse(parts[4]);
                  break;
                case "ChecklistGoal":
                  target = int.Parse(parts[4]);
                  break;
              }
            }
            if (parts.Length > 5)
            {
              bonus = int.Parse(parts[5]);
            }


            CreateGoal(goalType, name, description, points, target, bonus, isComplete);
          }
        }
      }
    }
    else
    {
      Console.WriteLine("File not found.");
    }
  }
}