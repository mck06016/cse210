using System;

class Program
{
    static void Main(string[] args)
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
                Console.WriteLine($"{menu.IndexOf(option)+1}.{option}");
            }
            Console.Write("What would you like to do? : ");
        }

        var choice = 0; 
        
        Journal myJournal = new Journal();

        while (choice != 5)  // While loop not essential as loop proceeding until Enviroment.Exit Called in choice 5
        {

        Menu();
        var response = Console.ReadLine();
        choice = int.Parse(response);

        if (choice == 1)  // Write
        {
            Entry newEntry = new Entry();
            var que = Prompt.DisplayPrompts();
            newEntry._prompt = 
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            newEntry._date = dateText;
            newEntry._entry = Console.ReadLine();
            myJournal._entry.Add(newEntry);
        }
        else if (choice == 2) // Display
        {
            Console.Write("Choice 2"); 
        }
        else if (choice == 3) // Load
        {
            Console.Write("Choice 3");
        }
        else if (choice == 4) // Save
        {
            Console.Write("Choice 4");
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