// Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static string GetDigitName(int digit)
    {
        string digitName;
        switch (digit)
        {
            case 0:
                digitName = "zero";
                break;
            case 1:
                digitName = "one";
                break;
            case 2:
                digitName = "two";
                break;
            case 3:
                digitName = "three";
                break;
            case 4:
                digitName = "four";
                break;
            case 5:
                digitName = "five";
                break;
            case 6:
                digitName = "six";
                break;
            case 7:
                digitName = "seven";
                break;
            case 8:
                digitName = "eight";
                break;
            case 9:
                digitName = "nine";
                break;
            default:
                digitName = "Invalid digit! Digit must be between 0 and 9.";
                break;
        }

        return digitName;
    }

    static void GetLastDigitName(int number)
    {
        int lastDigit = number % 10;
        Console.WriteLine("Last digit of number {0} is {1}", number, GetDigitName(lastDigit));
    }
    static void Main()
    {
        Console.WriteLine("Insert number");
        int number = int.Parse(Console.ReadLine());
        GetLastDigitName(number);
    }
}
