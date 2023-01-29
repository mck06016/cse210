using System;

public class Entry
{
    public string _entry;

    public string _date;

    public string _prompt;

    public Entry()
    {

    }

    public void Display()
    {
      Console.WriteLine($"------------------------------");
      Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
      Console.WriteLine($"Response: {_entry}");
      Console.WriteLine($"------------------------------");
      Console.WriteLine();
    
    }
}