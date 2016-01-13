//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

using System;
using System.Collections.Generic;
using System.Linq;
class PermutationsOfSet
{
    static void Main()
    {
        Console.Write("Array length = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        IEnumerable<int> result = from value in Enumerable.Range(1, n)
                                  select value;
        int[] array = result.ToArray();
        Permutation(array, 0, array.Length);
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
            {
                Console.Write("{0}, ", array[i]);
            }
            else
            {
                Console.WriteLine("{0}", array[i]);
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Permutation(int[] array, int start, int length)
    {
        if (start == length - 1)
        {
            Print(array);
            return;
        }
        else
        {
            for (int i = start; i < length; i++)
            {
                Swap(ref array[start], ref array[i]);
                Permutation(array, start + 1, length);
                Swap(ref array[start], ref array[i]);
            }
        }
    }
}
