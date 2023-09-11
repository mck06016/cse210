using System;

class Program
{

    /*
    Assignment Instructions
    For this assignment, write a C# program that has several simple functions:

    DisplayWelcome - Displays the message, "Welcome to the Program!"
    PromptUserName - Asks for and returns the user's name (as a string)
    PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    DisplayResult - Accepts the user's name and the squared number and displays them.
    Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
    */
    static void Main(string[] args)
    {
        /* Welcome Function*/
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        /*Ask for and return users name*/
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }
        /* Ask for and return users favorite number.*/
        static float PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string answer = Console.ReadLine();
            float favoriteNumber = float.Parse(answer);

            return favoriteNumber;
        }
        /*Returns the square of the favorite number.*/
        static float SquareNumber(float favoriteNumber)
        {
            float squared = favoriteNumber * favoriteNumber;

            return squared;
        }
        /* Displays results */
        static void DisplayResults (string userName, float squared)
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {squared}.");
        }

        /* I am struggling in Python the "Main" function was it's own function. But when I tried to do that the program does not work.*/

        DisplayWelcome();
        string userName = PromptUserName();
        float userNumber = PromptUserNumber();
        float squaredNumber = SquareNumber(userNumber);
        DisplayResults(userName,squaredNumber);
    }
}