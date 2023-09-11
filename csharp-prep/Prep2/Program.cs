using System;

class Program
{
    /* 
    Write a program that determines the letter grade for a course according to the following scale: A >= 90, B >= 80, C >= 70, D >= 60, F < 60.
    Same as CSE110 Week 5 Team Project
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
    if (grade >= 70)
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



    /*Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. For each grade, you'll know it is a "+" if the last digit is >= 7. You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.
    After your logic to determine the grade letter, add another section to determine the sign. Save this sign into a variable. Then, display both the grade letter and the sign in one print statement.
    Hint: To get the last digit, you could divide the number by 10, and get the remainder. You might refer back to the preparation material for Lesson 03 to see the operators and find the one that does division and gives you the remainder.
    At this point, don't worry about the exceptional cases of A+, F+, or F-.
    */

    /* Logic: 
    >7 = +
    <3 = -
    Between 4-6 - no symbol.

    Take float grade and modulus it to find the remainder then apply 3 levels of logic - Above = 7, Below = 3, everything else. 
    */
    float remainder = grade % 10;
    string bonus;

    if (remainder >= 7)
    {
      bonus = "+";
    }
    else if (remainder <= 3)
    {
      bonus = "-";
    }
    else
    {
      bonus = "";
    }


    /*Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.*/
    /*Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.*/

    if (letter == "A")
    {
      if (bonus == "+")
      {
        bonus = "";
      }
    }
    else if (letter == "F")
    {
      bonus = "";
    }

    Console.WriteLine($"You are getting an {letter}{bonus} in this course.");
    }
}