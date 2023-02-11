using System; 

public class Word
{
  private string _word;

  private bool _isHidden;

  

  public Word(string word)
  {
    _word = word;
    _isHidden = false;

  }


  public void Hide()
  {
    char[] characters = _word.ToCharArray();

    for (int i = 0; i < characters.Length; i++)
    {
      if (characters[i] != ',' && characters[i] != ':' && characters[i] != '.')  // Add more puncturation as needed !
      {
        characters[i] = '_';
      }
    }
   // _word = characters.ToString();
   _word = new string(characters);
    _isHidden = true;

  }

  public bool GetIsHidden()
  {
    return _isHidden;
  }
    public string GetWord()
  {
    return _word;
  }

}