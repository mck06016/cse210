using System;

/*  */
/*Guess My Number game the computer picks a magic number, and then the user tries to guess it. After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic number.*/

class Program
{
    static void Main(string[] args)
    {

        Random randomGen = new Random();
        int magic = randomGen.Next(1,100);

        int guess = -1;
        int count = 0;
        //Console.Write("What is the magic number? ");
        //string answer = Console.ReadLine();
        //int magic = int.Parse(answer);

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            string answer2 = Console.ReadLine();

            guess = int.Parse(answer2);
            count +=1;

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
            Console.WriteLine("You Guessed It!");
          }
        
        }
        Console.WriteLine($"It took {count} guesses.");
        
    }
}