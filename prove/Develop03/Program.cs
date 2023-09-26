using System;
using System.Diagnostics;
using System.IO.Enumeration;

class Program
{

    static void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select a set of scriptures to memorize from: ");
        List<string> menu = new List<string>()
        {
            "Articles of Faith",
            "Christus Narration",
            "The Teachings of Jesus Christ - Talk by Elder Dallin H. Oaks",
            "Scripture Mastery - Book of Mormon",
            "Scripture Mastery - Doctrine and Covenants", 
            "Scripture Mastery - Old Testemant",
            "Scripture Mastery - New Testement",
            "Quit",
        };
        foreach (string option in menu)
        {
            Console.WriteLine($"{menu.IndexOf(option) + 1}. {option} ");
        }
        Console.Write("Please enter the number of the set of scriptures you would like to select from? ");
    }


    static void Main(string[] args)
    {

        var choice = 0;
        string filename;
        

        while (choice != 8)
        {
            Menu();
            var response = Console.ReadLine();
            choice = int.Parse(response);

            if (choice == 1) // Articles of Faith
            {
                filename = "ArticlesOfFaith.txt";
            }
            else if (choice ==2) //Christus Narration
            {
                filename = "ChristusNarration.txt";
            }
            else if (choice ==3) //The Teachings of Jesus Christ - Talk by Elder Dallin H. Oaks
            {
                filename = "TheTeachingsOfJesusChrist.txt";
            }
            else if (choice ==4) //Scripture Mastery - Book of Mormon
            {
                filename = "ScriptureMasteryBOM.txt";
            }
            else if (choice ==5) //Scripture Mastery - Doctrine and Covenants
            {
                filename = "ScriptureMasteryDC.txt";
            }
            else if (choice ==6) //Scripture Mastery - Old Testemant
            {
                filename = "ScriptureMasteryOT.txt";
            }
            else if (choice ==7) //Scripture Mastery - New Testament
            {
                filename = "ScriptureMasteryNT.txt";
            }
            else if (choice ==8) // Quit
            {
                Console.WriteLine("Thank you for using this Scripture Memorizer.");
                Environment.Exit(0);
            }
            else
            {
                Console.Write("That is not a valid choice. Please choose again.");
            }

            Memorizer myMemorization = new Memorizer();
        }





    }
}