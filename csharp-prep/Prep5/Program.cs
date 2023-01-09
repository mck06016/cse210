using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        returnType FunctionName(dataType parameter1, dataType parameter2)
            {
                // function_body
            }
        */
        
        /*
        DisplayWelcome - Displays the message, "Welcome to the Program!"
        PromptUserName - Asks for and returns the user's name (as a string)
        PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        DisplayResult - Accepts the user's name and the squared number and displays them.
        */


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string answer = Console.ReadLine();

            int favoriteNumber = int.Parse(answer);
            
            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int squared = favoriteNumber * favoriteNumber;

            return squared;
        }

        static void DisplayResult(string userName, int squared)
        {
            Console.WriteLine($"{userName}, the square of your number is {squared}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }
}