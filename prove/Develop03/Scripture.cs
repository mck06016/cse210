

public class Scripture
{

  Reference myReference = new Reference();

  public List<Word> scripture = new List<Word>();


  public string passage = "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.";

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
      Word text = new Word(word);    // Code works until here - the scripture.Append(text) is not working. > Text is assigned two attributes _word and _isHidden False but it is not adding that to my List<word> scripture > Orignally scripture.Append(text); >> Changed to scripture.Add(text) and it looks like it works. 
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

  public bool CompletelyHidden()   // Not working - - leaving 1 word. 
  {
    foreach (Word word in scripture)
    {
      if (!(word.GetIsHidden()))  // word._isHidden = false (We can see the word)
      {
        return false;     //If we can see 1 word - - then Completly Hidden is NOT true - -  Completely Hidden = False *** But every time I run my code it leaves 1 word. 
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