//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSort
{
    static void Main()
    {
        //test data
        //int[] array = { 3, 4, 2, 1, 7, 5, 8, 9, 0, 6};

        //insert array's length
        Console.Write("Array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        Console.WriteLine();

        //insert array's elements
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //in result array we save sorted elements
        int[] result = new int[array.Length];
        MergeSortStep(array, array.Length, ref result);

        Console.WriteLine("Sorted elements");
        foreach (int element in result)
        {
            Console.WriteLine(element);
        }
    }

    static void MergeSortStep(int[] array, int size, ref int[] result)
    {
        //recursion base
        if (size <= 1)
        {
            return;
        }

        int middle = size / 2;
        int[] left = new int[middle];
        int[] right = new int [size - middle];
        int zeroForRight = 0;
        
        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }

        for (int i = middle; i < size; i++)
        {
            //we need to start from 0 in right array
            right[zeroForRight] = array[i];
            zeroForRight++;
        }

        MergeSortStep(left, middle, ref result);
        MergeSortStep(right, size - middle, ref result);
        Merge(left, right, ref result);

        //we need to save already sorted elements, because we continue recursion and gave array as 
        //argument in method 
        for (int i = 0; i < size; i++)
        {
            array[i] = result[i];
        }
    }

    static void Merge(int[] left, int[] right, ref int[] result)
    {
        int count = 0;
        int l = 0;
        int r = 0;

        while (l < left.Length && r < right.Length)
        {
            //i is increasing after =
            result[count++] = (left[l] < right[r] ? left[l++] : right[r++]);
        }

        while (l < left.Length)
        {
            result[count++] = left[l++];
        }

        while (r < right.Length)
        {
            result[count++] = right[r++];
        }
    }
}
