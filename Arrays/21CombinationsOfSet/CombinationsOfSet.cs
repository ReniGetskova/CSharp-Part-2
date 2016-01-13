//Write a program that reads two numbers N and K and generates all the combinations of K distinct 
//elements from the set [1..N].

using System;
using System.Collections.Generic;
using System.Linq;

class CombinationsOfSet
{
    static void Main()
    {
        //Combination 3 from 5 mean that we take 3 element from 5 and order does not important
        Console.Write("Insert: K = ");
        int takeNumbers = int.Parse(Console.ReadLine());
        Console.Write("Insert: N = ");
        int totalNumbers = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (takeNumbers > totalNumbers )
        {
            Console.WriteLine("N must be bigger than K");
            return;
        }

        IEnumerable<int> result = from value in Enumerable.Range(1, totalNumbers)
                                  select value;
        int[] array = result.ToArray();

        Combinatios(totalNumbers, takeNumbers, 0, array);
    }

    static void Combinatios(int totalNumbers, int takeNumbers, int index, int[] array)
    {
        if (takeNumbers == 0)
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            return;
        }

        if (totalNumbers == 0)
        {
            return;
        }

        array[index] = totalNumbers;
        Combinatios(totalNumbers - 1, takeNumbers - 1, index + 1, array);
        Combinatios(totalNumbers - 1, takeNumbers, index, array);
    }
}
