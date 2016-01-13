//Write a program that reads a string from the console and prints all different letters in the string along with 
//information how many times each letter is found.

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        //Console.WriteLine("Enter text:");
        //string text = Console.ReadLine();

        string text = "All different letters";
        Console.WriteLine(text);

        Dictionary<char, int> lettersCount = new Dictionary<char, int>();
        foreach (char letter in text)
        {
            if (!char.IsLetter(letter))
            {
                continue;
            }

            if (lettersCount.ContainsKey(letter))
            {
                lettersCount[letter]++;
            }
            else
            {
                lettersCount.Add(letter, 1);
            }
        }

        foreach (var item in lettersCount)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }
}

