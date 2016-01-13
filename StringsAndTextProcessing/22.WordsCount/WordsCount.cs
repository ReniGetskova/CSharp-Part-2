//Write a program that reads a string from the console and lists all different words in the string along with information 
//how many times each word is found.

using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        //Console.WriteLine("Enter text:");
        //string text = Console.ReadLine();

        string text = "All different words, from text of words.";
        Console.WriteLine(text);

        string[] words = text.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordsCount = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (wordsCount.ContainsKey(word))
            {
                wordsCount[word]++;
            }
            else
            {
                wordsCount.Add(word, 1);
            }
        }

        foreach (var item in wordsCount)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }
}

