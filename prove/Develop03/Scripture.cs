using System;


public class Scripture
{
  //Member Variables
  private string _book;
  private string _chapter;
  private string _startVerse;
  private string _endVerse;
  private string _passage;
  private string[] wordList;
  private List<Word> _scripture = new List<Word>();



  //Constructors
    public Scripture()
    {
    SplitPassage();
    }


  //Methods (Getters and Setters)
  public string GetBook()
  {
    return _book;
  }
  public string GetChapter()
  {
    return _chapter;
  }
  public string GetStartVerse()
  {
    return _startVerse;
  }
  public string GetEndVerse()
  {
    return _endVerse;
  }
  public string GetPassage()
  {
    return _passage;
  }
  
  public string SetBook(string Book)
  {
    _book = Book;
    return _book;
  }
  public string SetChapter(string Chapter)
  {
    _chapter = Chapter;
    return _chapter;
  }
  public string SetStartVerse(string StartVerse)
  {
    _startVerse = StartVerse;
    return _startVerse;
  }
  public string SetEndVerse(string EndVerse)
  {
    _endVerse = EndVerse;
    return _endVerse;
  }
  public string SetPassage(string Passage)
  {
    _passage = Passage;
    return _passage;
  }
  

  /* //Attempt to make the Scripter one Setter - - Not working.   
  public string SetScripture(string Book, string Chapter, string StartVerse, string EndVerse, string Passage)
  {
    _book = Book;
    _chapter = Chapter;
    _startVerse = StartVerse;
    _endVerse = EndVerse;
    _passage = Passage;

    return (_book, _chapter, _startVerse, _endVerse, _passage)
  }
  */



  //Methods
    public void SplitPassage()
    {
      wordList = _passage.Split(" ");
      foreach (string word in wordList)
      {
        Word text = new Word(word);
       _scripture.Add(text);
      }
    }
    



    
}