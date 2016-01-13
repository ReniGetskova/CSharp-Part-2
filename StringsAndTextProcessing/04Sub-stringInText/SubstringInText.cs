//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine.We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

using System;

class SubstringInText
{
    static void Main()
    {
        Console.WriteLine("Insert text");
        string text = Console.ReadLine();
        Console.WriteLine("\nInsert searched substring in text");
        string subString = Console.ReadLine();
        int count = 0;
        int index = text.IndexOf(subString);
        while (index != -1)
        {
            count++;
            index = text.IndexOf(subString, index + 1);
        }

        Console.WriteLine("\nSubsting \"{0}\" is contained {1} times in text", subString, count);
    }
}
