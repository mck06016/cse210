using System;

class Program
{
    /*
    Assignment - Same as Week 9 Team Project CSE110
    Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
    CORE
    1. Compute the sum, or total, of the numbers in the list.
    2. Computer the average of the numbers in the list.
    3. Find the maximum or largest, number in the list.

    The following shows the expected output:

    Enter a list of numbers, type 0 when finished.
    Enter number: 18
    Enter number: 36
    Enter number: 2
    Enter number: 48
    Enter number: 6
    Enter number: 12
    Enter number: 9
    Enter number: 0
    The sum is: 131
    The average is: 18.714285714285715
    The largest number is: 48

    STRETCH
    4 - Have the user enter both positive and negative numbers, ,then find the smallest positive number. (the positive number that is closest to zero.)
    5 - Sort the numbers in the list and display the new, sorted list. Hint" There are C# libraries that can help you here, try searching the internet for them.

    The following shows the expected output after completing the stretch challenges:

    Enter a list of numbers, type 0 when finished.
    Enter number: 3
    Enter number: 5
    Enter number: 7
    Enter number: 3
    Enter number: 2
    Enter number: -1
    Enter number: -4
    Enter number: -8
    Enter number: 0
    The sum is: 7
    The average is: 0.875
    The largest number is: 7
    The smallest positive number is: 2
    The sorted list is:
    -8
    -4
    -1
    2
    3
    3
    5
    7

    */

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int num = -1;
        int max = -999999;
        int total = 0;
        int min = 999999;
        int min_positive = 999999;

        while (num != 0)
        {
        Console.Write("Enter number: ");
        string entry = Console.ReadLine();
        num = int.Parse(entry);

        if (num != 0)
        {
            numbers.Add(num);
        }

        if (num > max)
        {
            max = num;
        }

        if (num < min)
        {
            min = num;
        }

        if (num > 0 && num < min_positive)
        {
            min_positive = num;
        }

        }

        foreach (int number in numbers)
        {
        total = total + number;
        }

        int length = numbers.Count;

        float average = ((float)total) / length;

        List<int> sorted_numbers = new List<int>();

        numbers.Sort();

        Console.WriteLine($"The sum is: {total}");    
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min_positive}");
        Console.WriteLine($"The smallest number is: {min}");
        Console.WriteLine("The sorted list is: ");
        foreach (int x in numbers)
        {
        Console.WriteLine(x);
        }

    }
}