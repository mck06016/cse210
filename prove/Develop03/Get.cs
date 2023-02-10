using System; 
using System.IO;

  public string[] wordList;

    public class Get()
  {

    string file = "passage.txt";


    string[] lines = System.IO.File.ReadAllLines(file);
    
    wordList = lines[0].Split(" ")
  }