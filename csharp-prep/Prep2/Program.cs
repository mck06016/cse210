using System;

class Program
{
    /* Write a program that determines the letter grade for a course according to the following scale: A >= 90, B >= 80, C >= 70, D >= 60, F < 60.


    */
    static void Main(string[] args)
    {
        /*Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)  */
        
        Console.Write("What is your grade percentage: ");
        string answer = Console.ReadLine();

        float grade = float.Parse(answer); 

        /*
        if (grade >= 90)
        {
            Console.WriteLine("You are getting an A in this course.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You are getting an B in this course.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You are getting an C in this course.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You are getting an D in this course.");
        }
        else
        {
            Console.WriteLine("You are getting an F in this course.");
        }
        */
        /*Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.  */
        if (grade >=70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
        /*Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once. */

        string letter = ("");

        if (grade >= 90)
        {
            letter = ("A");
        }
        else if (grade >= 80)
        {
            letter = ("B");
        }
        else if (grade >= 70)
        {
            letter = ("C");
        }
        else if (grade >= 60)
        {
            letter = ("D");
        }
        else
        {
            letter = ("F");
        }
        
        Console.WriteLine($"You are getting an {letter} in this course.");
   
    }
}