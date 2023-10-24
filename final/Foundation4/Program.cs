using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a List of Exercises

        List<Exercise> _exercise = new List<Exercise>();

        // Pre-entered Exercises

        Running e1 = new("October 19, 2023", 30, 5.5f);
        _exercise.Add(e1);

        StationaryBicycle e2 = new("October 20, 2023", 60, 18.9f);
        _exercise.Add(e2);

        Swimming e3 = new("October 21, 2022", 60, 50);
        _exercise.Add(e3);

        Console.WriteLine("Exercise: ");

        foreach (Exercise exercise in _exercise)
        {
            Console.WriteLine(exercise.GetSummary());
        }

    }
}