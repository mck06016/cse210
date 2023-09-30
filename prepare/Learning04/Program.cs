using System;

class Program
{
    static void Main(string[] args)
    {
        //Test Step 3.5
        Assignment One = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(One.Summary());

        Console.WriteLine();

        //Test 4.5
        MathAssignment Two = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(Two.Summary());
        Console.WriteLine(Two.HomeworkList());

        Console.WriteLine();

        //Test 5.6
        WrittingAssignment Three = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(Three.Summary());
        Console.WriteLine(Three.WritingInformation());
    }
}