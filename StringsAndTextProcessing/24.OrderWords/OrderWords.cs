//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;

class OrderWords
{
    static void Main()
    {
        //Console.WriteLine("Enter words separated by space:");
        //string text = Console.ReadLine();

        string text = "Print words in an alphabetical order";
        Console.WriteLine(text);
        string[] words = text.Split(' ');

        SortedSet<string> sortedWords = new SortedSet<string>();
        foreach (var word in words)
        {
            sortedWords.Add(word);
        }

        foreach (var item in sortedWords)
        {
            Console.WriteLine(item);
        }
    }
}
