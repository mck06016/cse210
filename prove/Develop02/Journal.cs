using System;
using System.IO;

public class Journal
{
  public List<Entry> entryList = new List<Entry>(); //List of New entries

  public List<Entry> loadList = new List<Entry>(); //List of Loaded entries

  private string fileName;

  public Journal()
  {
    
  }

  public void Write()
  {
    Entry entry = new Entry();
    entry.Write();
    entryList.Add(entry);

  }  

  public void Display()
    {
      foreach (Entry entry in entryList)  // Add all new entries to the Load List before displaying.
      {
        loadList.Add(entry);
      }
      foreach (Entry entry in loadList)  // Now that Load List has all entries (Old and New). Display all.
      {
        Console.WriteLine($"------------------------------");
        Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
        Console.WriteLine($"Response: {entry._entry}");
        Console.WriteLine($"------------------------------");
        Console.WriteLine();
      }
    }
  public void Load()
  {
    Console.Write("Enter the Filename: ");
    fileName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);

    for (int x = 0; x < lines.Count(); x+=3){
      Entry entry = new Entry();
      entry._date = lines[x];
      entry._prompt = lines[x+1];
      entry._entry = lines[x+2];
      loadList.Add(entry);
    }
  }

  public void SaveNew()
  {
    Console.Write("Enter the Filename: ");
    fileName = Console.ReadLine();

    foreach (Entry entry in entryList){
      using (StreamWriter file = new StreamWriter(fileName,append:true))
      {
        file.WriteLine(entry._date);
        file.WriteLine(entry._prompt);
        file.WriteLine(entry._entry);
      }
    }
  }

    public void SaveAll()
  {
    Console.Write("Enter the Filename: ");
    fileName = Console.ReadLine();
    foreach (Entry entry in entryList)  // Add all new entries to the Load List before displaying.
      {
        loadList.Add(entry);
      }
    foreach (Entry entry in loadList){
      using (StreamWriter file = new StreamWriter(fileName,append:true))
      {
        file.WriteLine(entry._date);
        file.WriteLine(entry._prompt);
        file.WriteLine(entry._entry);
      }
    }
  }


}


