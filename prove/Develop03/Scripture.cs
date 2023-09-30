using System.IO;

public class Scripture
{

  Reference myReference = new Reference("Joseph Smith - History","1","16","17");
 
  public string passage = "I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other— This is My Beloved Son. Hear Him!";

  private List<Word> scripture = new List<Word>();

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

  public string setPassage(string Script){
    passage = Script;
    return passage;
  }

/*public void GetScripture(){  //This is an attempt to pull it from a csv file.
      
  string filePath = "dc_mastery.csv";
  StreamReader reader = null;
  if (File.Exists(filePath)){
    reader = new StreamReader(File.OpenRead(filePath));
    List<string> listA = new List<string>();
    Scripture newScripture = new Scripture();
    while (!reader.EndOfStream){
      var line = reader.ReadLine();
      var values = line.Split(',');
      int i;
      for (i=0; i < values.Length; i++){
      if (i==0){
          string book = values[i];
          myReference.setBook(book);
      }
      else if (i == 1){
          string chapter = values[i];
          myReference.setChapter(chapter);
      }
      else if (i == 2){
          string verse1 = values[i];
          myReference.setVerse1(verse1);
      }
      else if (i == 3){
          string verse2 = values[i];
          myReference.setVerse2(verse2);
      }
      else if (i == 4){
          string script = values[i];
          passage = script;   
      }
      }
    }} 
  else {
    Console.WriteLine("File doesn't exist");
}}*/

}