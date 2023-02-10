

public class Scripture
{

  Reference myReference = new Reference();

  public List<Word> scripture = new List<Word>();


  public string passage = "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.";

  public string[] wordList;

  public Scripture()
  {
    foreach (string word in wordList)
    {
      Word text = new Word();
      text._word = word;
      scripture.Append(text);
    }
  }

  public void Split(){
    wordList = passage.Split(" ");
    
  }
  
  



}