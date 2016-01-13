﻿/*
A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:
input     | output
.NET      | platform for applications from Microsoft
CLR       | managed execution environment for .NET
namespace | hierarchical organization of classes
*/

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        var dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
        dictionary.Add("homework", "series of no less than 25 problems");

        Console.Write("Search for a word from the dictionary: ");
        string word = Console.ReadLine();

        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine("{0} - {1}", word, dictionary[word]);
        }
        else
        {
            Console.WriteLine("{0} not found in the dictionary", word);
        }
    }
}

