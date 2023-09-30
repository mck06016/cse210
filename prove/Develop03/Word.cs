using System; 

public class Word
{
//Member Variables
  private string _word;
  private bool _isHidden;

//Constructor
  public Word(string word)
  {
    _word = word;
    _isHidden = false;

  }

//Methods (Getters and Setters)
//To determine if a word has already been hidden or not.
  public bool GetIsHidden()
  {
    return _isHidden;
  }
  //To return the current state of the word.
    public string GetWord()
  {
    return _word;
  }

//Methods
//To Hide the alphabet characters of a word. For Example a word that is next to punctuation like " [Him!] or [you-] or [son's] " would retain the punctuation when the word is hidden - like " [___!] or [___-] or [___-_] ". This allows the scripture to be more memorable when words are hidden.
  public void Hide()
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