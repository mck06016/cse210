using System;

class Program
{

    static void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following options: ");
        List<string> menu = new List<string>()
        {
            "Write",
            "Display",
            "Load",
            "Save",
            "Quit",
        };
        foreach (string option in menu)
        {
            Console.WriteLine($"{menu.IndexOf(option)+1}.{option} ");
        }
        Console.Write("What would you like to do? : ");
    }

    static void Main(string[] args)
    {


        var choice = 0; 
        
        Journal myJournal = new Journal(); 

        while (choice != 5)  // While loop not essential as loop proceeding until Enviroment.Exit Called in choice 5
        {

            Menu();
            var response = Console.ReadLine();
            choice = int.Parse(response);

            if (choice == 1)  // Write
            {
                //Console.Write("Choice 1"); 
                myJournal.Write();
            }
            else if (choice == 2) // Display
            {
                //Console.Write("Choice 2"); 
                myJournal.Display();
            }
            else if (choice == 3) // Load
            {
                //Console.Write("Choice 3");
                myJournal.Load();
            }
            else if (choice == 4) // Save
            {
                //Console.Write("Choice 4");
                Console.WriteLine("Please select one of the following options: ");
                List<string> save = new List<string>()
                {
                    "Save a new file with all the entries",
                    "Save to an exsiting file the new entries.",
                    
                };
                foreach (string option in save)
                {
                    Console.WriteLine($"{save.IndexOf(option)+1}.{option}");
                }
                Console.Write("What would you like to do? : ");
                var saveChoice = Console.ReadLine();
                var saveOpt = int.Parse(saveChoice);

                if (saveOpt == 1)
                {
                    myJournal.SaveAll();
                }
                else if (saveOpt == 2)
                {
                    myJournal.SaveNew();
                }
            }
            else if (choice == 5) // Quit
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Write("That is not a valid choice. Please choose again.");
            }

        }
    }
}