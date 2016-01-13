//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine.We will move out of it in 5 days.
//Consider that the sentences are separated by.and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        //Console.WriteLine("Insert text");
        //string text = Console.ReadLine();
        StreamReader reader = new StreamReader(@"..\..\text.txt");
        string text = reader.ReadToEnd();
        reader.Close();
        Console.WriteLine("Insert searched word");
        string word = Console.ReadLine();
        string[] separateSentances = text.Trim().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        var result = new List<string>();

        for (int i = 0; i < separateSentances.Length; i++)
        {
            string[] words = separateSentances[i].Trim().Split(new[] { ' ', ',', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Contains(word))
            {
                result.Add(separateSentances[i]);
                result.Add(".");
            }
        }

        Console.WriteLine(string.Join("", result));
    }
}

