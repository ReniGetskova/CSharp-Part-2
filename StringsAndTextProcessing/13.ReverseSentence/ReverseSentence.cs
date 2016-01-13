/*Write a program that reverses the words in given sentence.
Example:
input: 
C# is not C++, not PHP and not Delphi!	
output:
Delphi not and PHP, not C++ not is C#!
*/

using System;
using System.Collections.Generic;
using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine(input);
        // Split the words and reverse their order
        char[] punctuationMarks = new char[] { ' ', ',', '.', ';', ':', '!', '?', '(', ')' };
        string[] words = input.Split(punctuationMarks, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        // Create a punctuation marks mask
        List<char> marksPosition = new List<char>();

        foreach (char character in input)
        {
            switch (character)
            {
                case ' ': marksPosition.Add(character); break;
                case ',': marksPosition.Add(character); break;
                case '.': marksPosition.Add(character); break;
                case ':': marksPosition.Add(character); break;
                case ';': marksPosition.Add(character); break;
                case '!': marksPosition.Add(character); break;
                case '?': marksPosition.Add(character); break;
                case '(': marksPosition.Add(character); break;
                case ')': marksPosition.Add(character); break;

                default: marksPosition.Add('ж'); break;
            }
        }

        // Replace the word placeholders from the mask with the words in reversed order 
        // and print them together with the punctuation marks
        int countMask = 0;
        int countWords = 0;

        for (int i = 0; i < marksPosition.Count; i++)
        {
            if ((marksPosition[i] == 'ж') && (countMask == 0))
            {
                Console.Write(words[countWords]);
                countMask++;
                countWords++;
            }
            else if (marksPosition[i] != 'ж')
            {
                Console.Write(marksPosition[i]);
                countMask = 0;
            }
        }

        Console.WriteLine();
    }
}
