/*
Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
*/

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter first date in the format day.month.year: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter second date in the format day.month.year: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        double days = (secondDate - firstDate).TotalDays;
        Console.WriteLine("{0} days", days);
    }
}

