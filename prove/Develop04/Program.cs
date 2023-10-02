using System;

class Program
{
    static void Main(string[] args)
    {

        DateTime start = DateTime.Now;
        bool quit = false;
        while (quit != true)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Options to exercise Mindfulness: ");
            Console.WriteLine("1. Start Beathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                // Breathing Activity
                /*
                Name = "Breathing Activity"

                Description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."


                */
                case "1":

                    Console.Clear();

                    BreathingActivity relax1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                    relax1.DisplayStartingMessage();

                    Console.WriteLine("1. Would you like to try Box Breathing? ");
                    Console.WriteLine("2. Or Would you like to do a Standard Relaxation Breathing Exercise.");
                    Console.Write("Select a choice from the menu: ");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            relax1.BoxBreathing();
                            break;
                        
                        case "2":
                            relax1.Run();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Not a Valid Selection. Please try again.");
                            Activity temp = new Activity();
                            temp.Spinner(5);
                            break;
                    }


                    relax1.DisplayEndingMessage();

                    break;

                // Reflection Activity
                /*
                Name = "Reflection Activity"

                Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."

                */
                case "2":

                    Console.Clear();

                    ReflectionActivity relax2 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                    relax2.DisplayStartingMessage();

                    relax2.Run();

                    relax2.DisplayEndingMessage();

                    break;
                //Listing Activity
                /*
                Name = "Listing Activity"

                Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                
                */
                case "3":
                    Console.Clear();

                    ListingActivity relax3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                    relax3.DisplayStartingMessage();


                    break;
                //Quit
                case "4":
                    quit = true;
                    Console.Clear();
                    Console.WriteLine("Thank you for taking time to exercise mindfullness today.");

                    break;
                //Invalud Entry (not 1-4)
                default:
                    Console.Clear();
                    Console.WriteLine("Not a Valid Selection. Please try again.");
                    Activity pause = new Activity();
                    pause.Spinner(5);
                    break;
            }
        }
        
    }
}