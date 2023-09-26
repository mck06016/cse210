using System;

public class Reference
{
  //Member Variables
  private string _bookName; 

  private string _chapter; 

  private string _verse;

  //Methods (Getters and Setters)
  public string getBook()
  {
    return _bookName;

  }
  public string getChapter()
  {
    return _chapter;
  }
  public string getVerse()
  {
    return _verse;
  }
  public string setBook(string Book)
  {
    _bookName = Book;
    return _bookName;
  }
  public string setChapter(string Chapter)
  {
    _chapter = Chapter;
    return _chapter;
  }
  public string setVerse1(string Verse1)
  {
    _verse = Verse1;
    return _verse;
  }

  //Constructors
  public Reference()
  {
    
  }
  public Reference(string Book, string Chapter, string Verse)
  {
    _bookName = Book;
    _chapter = Chapter;
    _verse = Verse;
  }
  public Reference (string Book, string Chapter, string startVerse, string endVerse)
  {
    _bookName = Book;
    _chapter = Chapter;
    _verse = $"{startVerse}-{endVerse}"; 

  }
  //Methods
  public string GetReferenceToString()
  {
    return $"{_bookName} {_chapter}:{_verse}";
  }

}