using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture();
        Reference myReference = new Reference();

        //If not using Selection of Scripture Block below - include this block:
        /*

        myScripture.setPassage("I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other— This is My Beloved Son. Hear Him!");
        myReference.setBook("Joseph Smith - History");
        myReference.setChapter("1");
        myReference.SetVerse2("16","17")'
        
        */

        //Beginning of Selection of Scripture

        Console.WriteLine("Please choose from the following 3 scriptures: ");
        Console.WriteLine("Scripture 1: 2 Nephi 25:26 - And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.");
        Console.WriteLine();
        Console.WriteLine("Scripture 2: 3 Nephi 9:15 - Behold, I am Jesus Christ. I created the heavens and the earth and all things that in them are. I was with the Father from the beginning.");
        Console.WriteLine();
        Console.WriteLine("Scripture 3: John 13:34-45 - A new commandment I give unto you- that you love one another as I have loved you- that ye also love one another. By this shall all men know that ye are my disciples.");
        Console.WriteLine();
        Console.Write("Please enter the number of the scripture you would like to memorize: ");
        var response = Console.ReadLine();
        var choice = 0;

        choice = int.Parse(response);

        if (choice ==1)
        {
            myScripture.setPassage("And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.");
            myReference.setBook("2 Nephi");
            myReference.setChapter("25");
            myReference.setVerse1("26");
        }
        else if (choice ==2)
        {
            myScripture.setPassage("Behold, I am Jesus Christ. I created the heavens and the earth and all things that in them are. I was with the Father from the beginning.");
            myReference.setBook("3 Nephi");
            myReference.setChapter("9");
            myReference.setVerse1("15");
        }
        else if (choice == 3)
        {
            myScripture.setPassage("A new commandment I give unto you- that you love one another as I have loved you- that ye also love one another. By this shall all men know that ye are my disciples.");
            myReference.setBook("John");
            myReference.setChapter("14");
            myReference.setVerse2("34", "35");
        }
        else{
            Console.WriteLine("That is not a valid choice. The program will now exit.");
            Environment.Exit(0);
        }

        //End of Selection of Scripture

        //Memorization Section 
        myScripture.SplitPassage();
        myReference.Display();
        myScripture.Display();
        string entry = "";
        while (myScripture.CompletelyHidden() is false && entry.ToLower() != "quit")
        {   
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            entry = Console.ReadLine();
            myScripture.HideWords();
            myReference.Display();
            myScripture.Display();
        }
    }
}