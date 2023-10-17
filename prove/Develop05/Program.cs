using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();

        //This question will be used to load a previously created Goals File and record. For purpose of testing type "Julia" as this file exists. You can also create your own file for testing. 
        //There is also a generic "Test" file.

        Console.Write("Who will be particpating in the Eternal Quest Today - This will be the file name that your goals are recorded under - Please enter your name: ");
        string name = Console.ReadLine();
        goalTracker.SetName(name);

        string fileName = $"{name}.txt";

        //Load Goals if available
        goalTracker.LoadGoals(fileName);

        int choice;

        do
        {
            Console.WriteLine("Eternal Quest Menu: ");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string entry = Console.ReadLine();
            choice = int.Parse(entry);

            switch (choice)
            {
                case 1: // Display Player Info
                    goalTracker.DisplayPlayerInfo();
                    break;

                case 2: // List Goal Names
                    goalTracker.ListGoalsNames();
                    break;

                case 3: // List Goals with Details
                    goalTracker.ListGoalsDetails();
                    break;

                case 4: //Create Goal
                    string goalType = goalTracker.GoalType();
                    Console.WriteLine();
                    Console.Write("Enter a name for the goal: ");
                    string goalName = Console.ReadLine();
                    Console.Write("Enter details and description relevant to the goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the points for completing this goal: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "SimpleGoal")
                    {
                        bool isComplete = false;
                        goalTracker.CreateGoal(goalType, goalName, description, points, isComplete);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        Console.Write("Enter a target number of times to complete the goal: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write($"Enter the bonus for completing the goal {target} times:  ");
                        int bonus = int.Parse(Console.ReadLine());
                        bool isComplete = false;
                        int amountCompleted = 0;

                        goalTracker.CreateGoal(goalType, goalName, description, points, isComplete, amountCompleted, target, bonus);
                    }
                    else
                    {
                        bool isComplete = false;
                        int amountCompleted = 0;
                        goalTracker.CreateGoal(goalType, goalName, description, points, isComplete, amountCompleted);
                    }
                    break;

                case 5: // Record Event
                    Console.Write("Enter the goal index to record an event: ");
                    int goalIndex = int.Parse(Console.ReadLine());
                    goalTracker.RecordEvent(goalIndex - 1);
                    break;

                case 6: // Save Goals
                    goalTracker.SaveGoal(fileName);
                    Console.WriteLine("Goals saved to file.");
                    break;

                case 7: // Exit
                    Console.WriteLine("Goodbye");
                    break;

                default:
                    Console.WriteLine("Invalid choice.Please try again.");
                    break;
            }
        } while (choice != 7);
    }
}