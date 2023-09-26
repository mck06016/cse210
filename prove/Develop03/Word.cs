using System; 

public class Word
{
  //Member Variables
  private string _word;
  private bool _isHidden;

  //Constructors
  public Word (string word)
  {
    _word = word;
    _isHidden = false;
  }
  //Methods (Getters and Setters)
  public bool GetIsHidden()
  {
    return _isHidden;
  }
  public string GetWord()
  {
    return _word;
  }

  //Methods
  public void Hide() //This takes a word and devides it to its characters, then if being hidden, replaces all a-z characters with and _ so that the word appears as ___ underscores in the text.
  {
    char[] characters = _word.ToCharArray();

    for (int i = 0; i < characters.Length; i++)
    {
      if (characters[i] != ',' && characters[i] != ':' && characters[i] != '.' && characters[i] !=';' && characters[i] !='"' && characters[i] !='?' && characters[i] !=']' && characters[i] !='[' && characters[i] !='}' && characters[i] !='{' && characters[i] !='(' && characters[i] !=')' && characters[i] !='!' && characters[i] !='~' && characters[i] !='`' && characters[i] != '—')  // Tried to cover the parts of puncuation
      {
        characters[i] = '_';
      }
    }
    _word = new string(characters);
    _isHidden = true; 
  }


}