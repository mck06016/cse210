using System;

public class Reference
{

  public string _bookName; 

  public int _chapter; 

  public int _verseStart;

  public int _verseEnd; 



  public void getBook()
  {
    _bookName = "1 Nephi";

  }

  public void getChapter()
  {
    _chapter = 1;
  }

  public void getVerseStart()
  {
    _verseStart = 1;
  }

  public void getVerseEnd()
  {
    _verseEnd = 1;
  }


 public Reference()
  {

  }

  public Reference(string Book, int Chapter, int Verse)
  {

  }

  public Reference (string Book, int Chapter, int startVerse, int endVerse)
  {
    

  }



}