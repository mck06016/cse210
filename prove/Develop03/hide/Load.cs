using System;
using System.IO;


public class Load{

  public string fileName;

  public string _newReference;

  public string _newScripture; 



    public void Load()
  {
    Console.Write("Enter the Filename: ");
    fileName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);

    for (int x = 0; x < lines.Count(); x+=2){
      _newReference = lines[x];  
      Console.WriteLine(_newReference);  
      _newScripture = lines[x+1];  
      Console.WriteLine(_newScripture);  
    }

    
  }
}
