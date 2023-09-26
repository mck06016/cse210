using System;

public class Memorizer
{
  //Member Variables
  private List<Scripture> _scriptureSet = new List<Scripture>();



  //Constructors
  public Memorizer()
  {

  }


  //Methods (Getters and Setters)




  //Method
  public void Load(string filename)
  {
    string[] lines = System.IO.File.ReadAllLines(filename);

    for (int x=0; x < lines.Count(); x+=5)
    {
      Scripture scripture = new Scripture();
      scripture.SetBook(lines[x]);
      scripture.SetChapter(lines[x + 1]);
      scripture.SetStartVerse(lines[x + 2]);
      scripture.SetEndVerse(lines[x + 3]);
      scripture.SetPassage(lines[x + 4]);
      _scriptureSet.Add(scripture);
    }
  }

  public void DisplayReference()
  {

    foreach (Scripture scripture in _scriptureSet)
    {
      
    }
  }


}