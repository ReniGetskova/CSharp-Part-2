//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;
class Reversestring
{
    static void Main()
    {
        Console.WriteLine("Insert some string");
        string input = Console.ReadLine();
        StringBuilder word = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            word.Append(input[i]);
        }

        Console.WriteLine("Reverse string: {0}", word);
    }
}
