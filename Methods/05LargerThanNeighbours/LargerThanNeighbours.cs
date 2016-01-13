//Write a method that checks if the element at given position in given array of integers is larger than its two 
//neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static void CheckIsLargerThenNeighbours(int position, params int[] array)
    {
        if (position > array.Length - 1)
        {
            Console.WriteLine("Invalid possition! Positon must be between 0 and {0}", array.Length - 1);
        }
        else if (position == array.Length - 1)
        {
            if (array[position] > array[position - 1])
            {
                Console.WriteLine("Last element {0} is larger than his neighbour {1}", array[position], array[position - 1]);
            }
            else
            {
                Console.WriteLine("Last element {0} is NOT larger than his neighbour {1}", array[position], array[position - 1]);
            }
        }
        else if (position == 0)
        {
            if (array[position] > array[position + 1])
            {
                Console.WriteLine("First element {0} is larger than his neighbour {1}", array[position], array[position + 1]);
            }
            else
            {
                Console.WriteLine("First element {0} is NOT larger than his neighbour {1}", array[position], array[position + 1]);
            }
        }
        else
        {
            if (array[position -1] < array[position] && array[position] > array[position + 1])
            {
                Console.WriteLine("Element {0} on position {1} is larger than his neighbours {2} and {3}", array[position], position, array[position - 1], array[position + 1]);
            }
            else
            {
                Console.WriteLine("Element {0} on position {1} is NOT larger than his neighbours {2} and {3}", array[position], position, array[position - 1], array[position + 1]);
            }
        }
    }
    
    static void PrintArray(params int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }       
    static void Main()
    {
        int[] numbersArray = {3, 2, 1, 5, 4, 7, 6, 11, 8, 9, 12, 15, 20, 13, 17};
        PrintArray(numbersArray);
        //try in that example with position 0, 2, 3, 14, and 15 to view all cases 
        int position = 15;
        CheckIsLargerThenNeighbours(position, numbersArray);
     
    }
}
