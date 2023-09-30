using System.IO;

public class Scripture
{
  //Member Variables (Primary)
    public string passage;

  //Member Variables (Secondary)
  private List<Word> scripture = new List<Word>();

  public string[] wordList;

  //Constructor
  public Scripture()
  {
    
  }

  //Methods (Getters and Setters);
  //Sets the Passage - Used in Program
  public string setPassage(string Script){
    passage = Script;
    return passage;
  }

  //Methods
  //Splits the long string of the passage into a list of individual words.
  public void SplitPassage() 
  {
    wordList = passage.Split(" ");
    foreach (string word in wordList)
    {
      Word text = new Word(word);     
      scripture.Add(text);
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
      int randomNum = random.Next(scripture.Count);
      
      if (!(scripture[randomNum].GetIsHidden()))
      {
        scripture[randomNum].Hide();
        i++;
      } 
    }
  }

//This tests if every word of the Scripture is hidden. If it is Completely Hidden the program can stop. 
  public bool CompletelyHidden()   
  {
    foreach (Word word in scripture)
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
    foreach (Word word in scripture)
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