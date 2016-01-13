//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20,
//the rest of the characters should be filled with *.

using System;
class StringLength
{
    static void Main()
    {
        string text;
        do
        {
            Console.WriteLine("Insert string of maximum 20 characters");
            text = Console.ReadLine();
        } while (text.Length > 20);
        if (text.Length < 20)
        {
            text = text.PadRight(20, '*');
        }

        Console.WriteLine(text);
    }
}
