using System.IO;

public class Scripture
{
  //Member Variables (Primary)
  /*Testing two scriptures
  Reference myReference = new Reference("Joseph Smith - History","1","16","17");

  public string passage = "I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other— This is My Beloved Son. Hear Him!";
  */

  public string passage;

  //Member Variables (Secondary)
  private List<Word> scripture = new List<Word>();

  public string[] wordList;

  //Constructor
  public Scripture()
  {
    
  }

  //Methods (Getters and Setters);
  public string setPassage(string Script){
    passage = Script;
    return passage;
  }


  //Methods
  public void SplitPassage() 
  {
    wordList = passage.Split(" ");
    foreach (string word in wordList)
    {
      Word text = new Word(word);     
      scripture.Add(text);
    }
  }
  
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


  public string GetScriptureText()
  {
    string text = "";
    foreach (Word word in scripture)
    {
      text = text + " " + word.GetWord();
    }

    return text;
  }

  public void Display ()
  {
    Console.WriteLine($"{GetScriptureText()}");
  }

}