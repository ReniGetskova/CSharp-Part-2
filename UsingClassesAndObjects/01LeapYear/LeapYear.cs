//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Insert year");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Is {0} a leap year: {1}", year, isLeap);
    }
}
