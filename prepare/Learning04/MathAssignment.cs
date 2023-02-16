
public class MathAssignment
{
  private string _textbookSection;

  private string _problems;


  public MathAssignment(string TextbookSection, string Problems)
  {
    _textbookSection = TextbookSection;
    _problems = Problems;
  }

  public string GetTextbookSection()
  {
    return _textbookSection;
  }

  public string GetProblems()
  {
    return _problems;
  }

  public string GetHomeworkList()
  {
    return _textbookSection + " - " + _problems;
  }

}