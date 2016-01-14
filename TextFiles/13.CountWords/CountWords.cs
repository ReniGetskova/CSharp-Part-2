//Write a program that reads a list of words from the file words.txt and finds how many times each of the words 
//is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences
//in descending order.

using System.Collections.Generic;
using System.IO;
using System.Linq;

class CountWords
{
    static void Main()
    {
        string[] text = ReadFromFile(@"..\..\text.txt");
        string[] words = ReadFromFile(@"..\..\words.txt");
        Dictionary<string, int> wordsDictionary = CountWordsOccurance(text, words);
        SaveResult(wordsDictionary, @"..\..\result.txt");
    }

    static string[] ReadFromFile(string fileName)
    {
        string[] words;
        using (StreamReader reader = new StreamReader(fileName))
        {
            words = reader.ReadToEnd().Replace("\r\n", " ").Split(' ');
        }

        return words;
    }

    public static Dictionary<string, int> CountWordsOccurance(string[] text, string[] words)
    {
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
        int counter = 0;

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] == words[i])
                {
                    counter++;
                }
            }

            wordsDictionary.Add(words[i], counter);
            counter = 0;
        }

        return wordsDictionary;
    }

    private static void SaveResult(Dictionary<string, int> wordsDictionary, string fileName)
    {
        var sortedDictionary = wordsDictionary.OrderByDescending(x => x.Value);

        using (StreamWriter writer = new StreamWriter(fileName)) //check the result in this file
        {
            foreach (var item in sortedDictionary)
            {
                writer.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}