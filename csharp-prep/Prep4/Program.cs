using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int num =-1;
        // Sum, Average, Max
        int total = 0;
        int max = -1;

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
        }

        foreach (int number in numbers)
        {
            total = total + number;
        }
        int length = numbers.Count;

        float average = ((float)total) / length;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}