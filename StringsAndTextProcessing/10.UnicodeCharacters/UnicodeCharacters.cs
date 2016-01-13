//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:
//input | output
//Hi!	| \u0048\u0069\u0021

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:X4}", Convert.ToUInt16(input[i]));
        }

        Console.WriteLine();
    }
}

