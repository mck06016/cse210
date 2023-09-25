using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        //Console.Write("Fraction String: ");
        Console.WriteLine(one.GetFractionString());
        //Console.Write("Decimal Value: ");
        Console.WriteLine(one.GetDecimalValue());
        //Console.Write("Get Top: ");
        //Console.WriteLine(one.GetTop());
        //Console.Write("Get Bottom: ");
        //Console.WriteLine(one.GetBottom());

        Fraction two = new Fraction(5);
        //Console.Write("Fraction String: ");
        Console.WriteLine(two.GetFractionString());
        //Console.Write("Decimal Value: ");
        Console.WriteLine(two.GetDecimalValue());
        //Console.Write("Get Top: ");
        //Console.WriteLine(two.GetTop());
        //Console.Write("Get Bottom: ");
        //Console.WriteLine(two.GetBottom());

        Fraction three = new Fraction(3,4);
        //Console.Write("Fraction String: ");
        Console.WriteLine(three.GetFractionString());
        //Console.Write("Decimal Value: ");
        Console.WriteLine(three.GetDecimalValue());
        //Console.Write("Get Top: ");
        //Console.WriteLine(three.GetTop());
        //Console.Write("Get Bottom: ");
        //Console.WriteLine(three.GetBottom());

        Fraction four = new Fraction(1,3);
        //Console.Write("Fraction String: ");
        Console.WriteLine(four.GetFractionString());
        //Console.Write("Decimal Value: ");
        Console.WriteLine(four.GetDecimalValue());
        //Console.Write("Get Top: ");
        //Console.WriteLine(four.GetTop());
        //Console.Write("Get Bottom: ");
        //Console.WriteLine(four.GetBottom());
    }
}