using System.IO;

public class Scripture
{
  //Member Variables 
  private string _passage;
  private List<Word> _scripture = new List<Word>();

  private string[] _wordList;

  //Constructor
  public Scripture()
  {
    
  }

  //Methods (Getters and Setters);
  //Sets the Passage - Used in Program
  public string SetPassage(string Script){
    _passage = Script;
    return _passage;
  }

  //Methods
  //Splits the long string of the passage into a list of individual words.
  public void SplitPassage() 
  {
    _wordList = _passage.Split(" ");
    foreach (string word in _wordList)
    {
      Word text = new Word(word);     
      _scripture.Add(text);
    }
  }
  
  //Generates a Random number between 1 & 5 to be hidden. Then generates a random number to select which word is hidden. After checking if the word is hidden it will either hide the word or proceed with generating a new random number to select a different word to check.
  public void HideWords()
  {
    int i = 0;
    Random count = new Random();
    int randomCount = count.Next(1,5);

    while (i<randomCount && !(CompletelyHidden()))  
    {
      Random random = new Random();
      int randomNum = random.Next(_scripture.Count);
      
      if (!(_scripture[randomNum].GetIsHidden()))
      {
        _scripture[randomNum].Hide();
        i++;
      } 
    }
  }

//This tests if every word of the Scripture is hidden. If it is Completely Hidden the program can stop. 
  public bool CompletelyHidden()   
  {
    foreach (Word word in _scripture)
    {
      if (!(word.GetIsHidden())) 
      {
        return false;    
      }
    }
    return true;  
  }

//This returns the list of words into a single string of text. Words that are already hidden have had their characters replaced with _ then the new scripture can be displayed on the screen. 
  public string GetScriptureText()
  {
    string text = "";
    foreach (Word word in _scripture)
    {
      text = text + " " + word.GetWord();
    }
    return text;
  }
//This displays the scripture in what ever form of hidden or not hidden that it is in. The clear function is not included here it is in the Reference.Display() method as the reference is displayed first. 
  public void Display ()
  {
    Console.WriteLine($"{GetScriptureText()}");
  }

}