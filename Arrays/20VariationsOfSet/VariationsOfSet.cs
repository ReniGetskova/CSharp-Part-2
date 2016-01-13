//Write a program that reads two numbers N and K and generates all the variations of K elements from 
//the set [1..N].

using System;
using System.Collections.Generic;
using System.Linq;

class VariationsOfSet
{
    static void Main()
    {
        Console.Write("Insert number of loops: K = ");
        int numberOfLoops = int.Parse(Console.ReadLine());
        Console.Write("Insert number of iterations: N = ");
        int numberOfIterations = int.Parse(Console.ReadLine());
        if (numberOfLoops > numberOfIterations)
        {
            Console.WriteLine("N must be bigger than K");
            return;
        }

        Console.WriteLine();
        IEnumerable<int> result = from value in Enumerable.Range(1, numberOfIterations)
                                  select value;
        int[] loops = result.ToArray();

        Variations(loops, 0,  numberOfLoops, numberOfIterations);
    }

    static void Print(int[] loops, int numberOfLoops)
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            if (i != numberOfLoops - 1)
            {
                Console.Write("{0}, ", loops[i]);
            }
            else
            {
                Console.WriteLine("{0}", loops[i]);
            }
        }
    }

    static void Variations(int[] loops, int currentLoop, int numberOfLoops, int numberOfIterations)
    {
        if (currentLoop == numberOfLoops)
        {
            Print(loops, numberOfLoops);
            return;
        }

        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            Variations(loops, currentLoop + 1, numberOfLoops, numberOfIterations);
        }
    }
}
