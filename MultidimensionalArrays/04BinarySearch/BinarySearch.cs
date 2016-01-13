//Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
//and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinarySearch
{
    static void Main()
    {
        //test data

        //int[] array = { 5, 4, 3, 6, 2 };
        //int k = 7;

        //int[] array = { 5, 4, 3, 6, 2 };
        //int k = 1;

        //int[] array = { 5, 1, 3, 6, 2 };
        //int k = 4;

        //int[] array = { 5, 1, 3, 6, 2 };
        //int k = 3;

        //insert array's length
        Console.Write("Insert array's length: n = ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        // insert k
        Console.Write("Insert number k = ");
        int k = int.Parse(Console.ReadLine());
        //insert array's elements
        Console.WriteLine("\nWrite array's elements on one line separatet by space");
        string elements = Console.ReadLine();
        string[] arrayElements = elements.Split(' ');
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayElements[i]);
        }

        //sort aaray
        Array.Sort(array);
        int index = Array.BinarySearch(array, k);
       
        //print sorted array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        //searched element is in array and print it -> 4) test case
        if (index >= 0)
        {
            Console.WriteLine("\nElement that is = {0} is: {1}", k, array[index]);
        }
        //searche element is not in array and we print <
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                // 2) test case
                if (array[i] > k && i == 0)
                {
                    Console.WriteLine("\nThere is not such a element");
                    break;
                }
                // if we have to print last element -> 1) test case
                else if (array[i]  <= k && i == array.Length - 1)
                {
                    Console.WriteLine("\nElement that is < {0} is: {1}", k, array[i]);
                    break;
                }
                // 3 )test case
                else if (array[i] >= k)
                {
                    Console.WriteLine("\nElement that is < {0} is: {1}", k, array[i - 1]);
                    break;
                }
            }
        }

    }
}
