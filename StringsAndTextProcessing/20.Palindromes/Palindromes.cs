//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe

using System;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        //Console.WriteLine("Enter text:");
        //string text = Console.ReadLine();
        string text = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
        string[] words = text.Split(new[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words)
        {
            //skip word with lenght 1 
            if (word.Length == 1)
            {
                continue;
            }

            string reversed = new string(word.Reverse().ToArray());
            if (word == reversed)
            {
                //palindrome
                Console.WriteLine("{0} ", word);
            }
        }
    }
}

