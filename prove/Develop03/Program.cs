using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture();
        
        string entry = "";
        while (myScripture.CompletelyHidden() is false && entry.ToLower() != "quit")
        {   
            myScripture.Display();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            entry = Console.ReadLine();

            myScripture.HideWords();
        }
    }
}