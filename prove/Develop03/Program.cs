using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture();
        myScripture.Display();
        string entry = "";
        while (myScripture.CompletelyHidden() is false && entry.ToLower() != "quit")
        {   
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            entry = Console.ReadLine();
            myScripture.HideWords();
            myScripture.Display();

        }
    }
}