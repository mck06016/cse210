using System;


public class Entry
{
    public string _entry;

    public string _date;

    private DateTime _dateTime = DateTime.Now;

    public string _prompt;

    private Prompt _newPrompt = new Prompt();

    public Entry()
    {

    }

    public void Write()
    {
      _date = _dateTime.ToShortDateString();
      _prompt = _newPrompt.GetPrompts();
      Console.WriteLine(_prompt);
      Console.Write("Entry: ");
      _entry = Console.ReadLine();

    }

    
}