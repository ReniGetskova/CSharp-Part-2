//Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Reverse(decimal number)
    {
        //convert number to string and loop that string from the end to start
        string numberToString = number.ToString();
        for (int i = numberToString.Length - 1; i >= 0; i--)
        {
            Console.Write(numberToString[i]);
        }

        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Insert decimal number");
        decimal number = decimal.Parse(Console.ReadLine());
        Reverse(number);
    }
}
