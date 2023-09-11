using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        In the Guess My Number game the computer picks a magic number, and then the user tries to guess it. After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic number.
        This assignment is a little tricky, because it brings together many of the concepts you've learned in this course including loops and if statements.
        Same as Week 7 Team Project CSE110
        */

        /* CORE Requirements
        1 - Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)
        Ask the user for a guess.
        Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.
        At this point, you won't have any loops.
        The following shows the expected output at this point:
            What is the magic number? 6
            What is your guess? 4
            Higher

            What is the magic number? 6 
            What is your guess? 7
            Lower

            What is the magic number? 6
            What is your guess? 6
            You guessed it!
        */
        /*
            Console.Write("What is the magic number? ");
            string answer = Console.ReadLine();
            int magic = int.Parse(answer);

            Console.Write("What is your guess? ");
            string answer2 = Console.ReadLine();
            int guess = int.Parse(answer2);

            if (magic > guess)
            {
            Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
            Console.WriteLine("Lower");
            }
            else{
            Console.WriteLine("You guessed it!");
            }
        */
        /*Core 1 Done*/


        /*Add a loop that keeps looping as long as the guess does not match the magic number.

        At this point, the user should be able to keep playing until they get the correct answer.*/
        /*
            Console.Write("What is the magic number? ");
            string answer = Console.ReadLine();
            int magic = int.Parse(answer);

            int guess = -1; 

            while (guess != magic)
            {
            Console.Write("What is your guess? ");
                string answer2 = Console.ReadLine();
                guess = int.Parse(answer2); 

                if (magic > guess)
                {
                Console.WriteLine("Higher");
                }
                else if (magic < guess)
                {
                Console.WriteLine("Lower");
                }
                else{
                Console.WriteLine("You guessed it!");
                }
            }
        */
        /*Core 2 Done*/

        /*Instead of having the user supply the magic number, generate a random number from 1 to 100.*/

        /*
            Random randomGen = new Random();
            int magic = randomGen.Next(1, 100);

            int guess = -1;

            while (guess != magic)
            {
            Console.Write("What is your guess? ");
                string answer2 = Console.ReadLine();
                guess = int.Parse(answer2); 

                if (magic > guess)
                {
                Console.WriteLine("Higher");
                }
                else if (magic < guess)
                {
                Console.WriteLine("Lower");
                }
                else{
                Console.WriteLine("You guessed it!");
                }
            }
        */
        /*Core 3 - Done - Tested Game works as expected*/

        /* Stretch Challenges - 
        1. Keep track of how many guesses the user has made and inform them of it a the end of the game.
        2. After the game is over, ask the user fi they want to play again. Then, loop back and play the whole game again and continue the loop as long as they keep saying "yes"
        */

        string repeat = "yes";

        while (repeat.ToLower() == "yes")
        {

        Random randomGen = new Random();
        int magic = randomGen.Next(1, 100);

        int guess = -1;
        int count = 0;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            string answer2 = Console.ReadLine();
            guess = int.Parse(answer2);
            count += 1;

            if (magic > guess)
            {
            Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
            Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine($"You made {count} guesses!");
        Console.Write("Would you like to play again? (yes / no) ");
        repeat = Console.ReadLine();
        }
    }
}