using System;

public class Reference
{

  public string _bookName = "John"; 

  public string _chapter = "11"; 

  public string _verse = "6";


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

  public string GetReferenceToString()
  {
    return $"{_bookName} {_chapter}:{_verse}";
  }

}