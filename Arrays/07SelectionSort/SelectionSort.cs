//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

using System;
class SelectionSort
{
    static void Main()
    {
        //test data
        //int[] array = { 10,9,6,5,7,1,4,3,2,8};

        //insert array's elements
        Console.Write("Array length = ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        Console.WriteLine();
        for (int element = 0; element < array.Length; element++)
        {
            Console.Write("Element [{0}] = ", element);
            array[element] = int.Parse(Console.ReadLine());
        }

        int min;
        int temp;

        for (int i = 0; i < array.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    //take index
                    min = j;
                }
            }
            //exchange values
            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

        //print sorted array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}
