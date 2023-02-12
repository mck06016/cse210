

public class Scripture
{

  Reference myReference = new Reference();

  private List<Word> scripture = new List<Word>();


  private string passage = "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.";

  public string[] wordList;

  public Scripture()
  {
    SplitPassage();

  }

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
    Console.Clear();

    Console.WriteLine($"{myReference.GetReferenceToString()} - {GetScriptureText()}");

  }

  


}