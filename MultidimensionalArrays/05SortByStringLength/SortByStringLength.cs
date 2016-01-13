//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;

class SortByStringLength
{
    static void Main()
    {
        //insert aaray's elements
        Console.Write("How many words you want to have in the array? -> n = ");
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        Console.WriteLine("Insert words on one line separated by space");
        string input = Console.ReadLine();
        words = input.Split(' ');

        //use selection sort
        string temp;
        int min = 0;
        for (int first = 0; first < words.Length; first++)
        {
            min = first;
            for (int second = first + 1; second < words.Length; second++)
            {
                if (words[min].CompareTo(words[second]) > 0)
                {
                    min = second;
                }
            }
            temp = words[first];
            words[first] = words[min];
            words[min] = temp;
        }

        //print sorted array from words
        for (int word = 0; word < words.Length; word++)
        {
            Console.Write(words[word] + " ");
        }
        Console.WriteLine();

        //test compare method
        //string a = "b";
        //string b = "a";
        //int index = a.CompareTo(b);
        //Console.WriteLine(index);
    }
}
