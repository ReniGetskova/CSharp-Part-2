//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;

class DayOfWeek
{
    static void Main()
    {
        DateTime day = DateTime.Now;
        System.DayOfWeek dayOfWeek = day.DayOfWeek;
        Console.WriteLine("Today is {0}", dayOfWeek);
    }
}
