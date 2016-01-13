//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is 
//implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is 
//implemented as a dynamic language in ***.

using System;
using System.IO;

class ForbiddenWords
{
    static void Main()
    {
        //Console.WriteLine("Enter text");
        //string text = Console.ReadLine();
        StreamReader reader = new StreamReader(@"..\..\text.txt");
        string text = reader.ReadToEnd();
        reader.Close();
        Console.WriteLine("Enter a list of forbidden words, separated by a space and/or ',': ");
        string[] forbiddenWords = Console.ReadLine().Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }

        Console.WriteLine();
        Console.WriteLine(text);
    }
}

