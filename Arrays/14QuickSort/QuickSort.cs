//Write a program that sorts an array of strings using the Quick sort algorithm.


using System;
using System.Linq;

class QuickSort
{
    static void Main()
    {
        //Program work only for first half of array. I tried to fix it but I could not find the problem
        //If you can help me with writing some useful feedback, I will be very grateful :)
        int[] array = { 3, 4, 2, 1, 7, 5, 8, 9, 0, 6 };
        Quick(array, array.Length);
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }

    private static void swapif(ref int a, ref int b)
    {
        if (b < a)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    private static void swap(ref int a, ref int b)
    {

        int temp = a;
        a = b;
        b = temp;
    }

    private static void Quick(int[] array, int size)
    {
        //recursion base
        if (size <= 1)
        {
            return;
        }

        int position = Partition(array, size);

        Quick(array, position);
        Quick(array.Skip(position + 1).ToArray(), size - position - 1);

    }

    private static int Partition(int[] array, int size)
    {
        if (size == 2)
        {
            swapif(ref array[0], ref array[1]);
            return 1;
        }

        //take 3 elements - first, middle and last and put them in increasing order
        int middle = size / 2;
        swapif(ref array[0], ref array[middle]);
        swapif(ref array[0], ref array[size - 1]);
        swapif(ref array[middle], ref array[size - 1]);

        //swap middle with element before last
        swap(ref array[middle], ref array[size - 2]);

        int  partitioningElement = array[size - 2];

        int left = 0;
        int right = size - 2;

        while (true)
        {
            while (array[++left] < partitioningElement)
            {
                ;
            }
            while (array[--right] > partitioningElement)
            {
                if (left == right)
                {
                    break;
                }
            }

            if (left >= right)
            {
                break;
            }

            swap(ref array[left], ref array[right]);
        }
        array[size - 2] = partitioningElement;
        swap(ref array[left], ref array[size - 2]);

        return left;
    }


}
