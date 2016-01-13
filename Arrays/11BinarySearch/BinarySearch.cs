//Write a program that finds the index of given element in a sorted array of integers by using the 
//Binary search algorithm.

using System;
class BinarySearch
{
    static void Main()
    {
        //test data
        //int[] array = { 19, 2, 11, 23, 45, 36, 63, 58, 76, 69, 92, 81 };

        //insert array' length
        Console.Write("Array length: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //insert array' elements
        Console.WriteLine("Insert sorted array");
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        //check if inserted array is not sorted, sort the array
        bool isSorted = true;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
            {
                isSorted = false;
                break;
            }
        }
        if (!isSorted)
        {
            Array.Sort(array);
            Console.WriteLine("Sorted array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element [{0}] = {1}", i, array[i]);
            }
        }

        Console.Write("\nWhich element do you want to find in the array: ");
        int searchElement = int.Parse(Console.ReadLine());
        int searchIndex = Search(array, searchElement, 0, array.Length - 1);
        if (searchIndex < 0)
        {
            Console.WriteLine("\nElement not found!");
        }
        else
        {
            Console.WriteLine("\nSearched element {0} is on position {1}", array[searchIndex], searchIndex);
        }
    }

    private static int Search(int[] array, int searchElement, int startPosition, int endPosition)
    {
        //check for invalid array
        if (endPosition < startPosition)
        {
            return -2;
        }
        else
        {
            int middle = (startPosition + endPosition) / 2;
            if (array[middle] > searchElement)
            {
                return Search(array, searchElement, startPosition, middle - 1);
            }
            else if (array[middle] < searchElement)
            {
                return Search(array, searchElement, middle + 1, endPosition);
            }
            else if (array[middle] == searchElement)
            {
                return middle;
            }
            else return -1;
        }

    }
}
