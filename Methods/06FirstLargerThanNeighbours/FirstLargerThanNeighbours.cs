//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1,
//if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static bool CheckIsLargerThenNeighbours(int position, params int[] array)
    {
        bool isLarger = false;
        if (position > array.Length - 1)
        {
            return isLarger;
        }
        else if (position == array.Length - 1)
        {
            if (array[position] > array[position - 1])
            {
                isLarger = true;
                return isLarger;
            }
            else
            {
                return isLarger;
            }
        }
        else if (position == 0)
        {
            if (array[position] > array[position + 1])
            {
                isLarger = true;
                return isLarger;
            }
            else
            {
                return isLarger;
            }
        }
        else
        {
            if (array[position - 1] < array[position] && array[position] > array[position + 1])
            {
                isLarger = true;
                return isLarger;
            }
            else
            {
                return isLarger;
            }
        }
    }
    
    static void Main()
    {
        int[] array = {4, 4, 1, 5, 4, 7, 6, 11, 8, 9, 12, 15, 20, 13, 17};
        //test data
        //int[] array = { 5, 5, 4, 3, 2, 7 };
        //int[] array = { 5, 5, 4, 3, 2, 1 };
        for (int i = 0; i < array.Length; i++)
        {
            if (CheckIsLargerThenNeighbours(i, array))
            {
                Console.WriteLine(i);
                break;
            }
            else if (!CheckIsLargerThenNeighbours(i, array) && i == array.Length - 1)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
