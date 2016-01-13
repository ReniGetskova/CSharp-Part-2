//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
class IndexOfletters
{
    static void Main()
    {
        Console.WriteLine("Insert word in the console");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write("{0} ", (int)word[i] - (int)'A'); 
        }
        Console.WriteLine();
    }
}
