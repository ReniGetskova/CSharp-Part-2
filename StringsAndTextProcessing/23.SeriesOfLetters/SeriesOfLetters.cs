//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example
//input	                  | output
//aaaaabbbbbcdddeeeedssaa | abcdedsa

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        //Console.WriteLine("Enter a word with sequence of identical letters:");
        //string word = Console.ReadLine();

        string word = "aaaaabbbbbcdddeeeedssaa";
        Console.WriteLine(word);

        StringBuilder result = new StringBuilder();
        char lastChar = '\0';

        foreach (var letter in word)
        {
            if (letter != lastChar)
                result.Append(letter);

            lastChar = letter;
        }

        Console.WriteLine(result);
    }
}

