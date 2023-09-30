using System;

public class Reference
{
//Member Variables
  private string _bookName; 

  private string _chapter; 

  private string _verse;

//Constructor
  public Reference()
  {
    
  }

//Methods (Getters and Setters)
//Sets Book.
  public string setBook(string Book)
  {
    _bookName = Book;
    return _bookName;
  }
//Sets Chapter.
  public string setChapter(string Chapter)
  {
    _chapter = Chapter;
    return _chapter;
  }
//Sets Verse if there is 1 Verse.
  public string setVerse1(string Verse1)
  {
    _verse = Verse1;
    return _verse;
  }
//Sets Verses if there is 2 Verses.
  public string setVerse2(string Verse1, string Verse2)
  {
    _verse = $"{Verse1}-{Verse2}";
    return _verse;
  }

//Methods
//Used in earlier iterations of my program but kept in as it is one of the requirements of the program.
  public Reference(string Book, string Chapter, string Verse)
  {
    _bookName = Book;
    _chapter = Chapter;
    _verse = Verse;
  }

//Used in earlier iterations of my program but kept in as it is one of the requirements of the program.
  public Reference (string Book, string Chapter, string startVerse, string endVerse)
  {
    _bookName = Book;
    _chapter = Chapter;
    _verse = $"{startVerse}-{endVerse}"; 
  }

//Returns the "String" of the Scripture Reference
  public string GetReferenceToString()
  {
    return $"{_bookName} {_chapter}:{_verse}";
  }

//Clears the Display and then prints the scripture reference with a - so the scripture can be printed next.
  public void Display()
  {
    Console.Clear();
    string reference = GetReferenceToString();
    Console.Write($"{reference} - ");
  }

}