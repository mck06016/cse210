using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Step 3.5
        Assignment One = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(One.GetSummary());

        // Test Step 4.6
        Assignment Two = new Assignment("Roberto Rodriguez", "Fractions");
        Console.WriteLine(Two.GetSummary());
        MathAssignment Three = new MathAssignment("Section 7.3", "Problems 8-19");
        Console.WriteLine(Three.GetHomeworkList());

        // Test 5.6
        Assignment Four = new Assignment("Mary Waters","European History");
        Console.WriteLine(Four.GetSummary());
        WrittingAssignment Five = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(Five.GetWrittingInformation());

    }
}