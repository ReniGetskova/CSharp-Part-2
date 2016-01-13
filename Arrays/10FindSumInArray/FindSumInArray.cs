// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
class FindSumInArray
{
    static void Main(string[] args)
    {
        //test data
        //int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        //int s = 11;

        //test data
        //int[] array = { 1, 2, 3, 6, 5, 4, 2, 3, 9 };
        //int s = 6;

        //insert array' length
        Console.Write("Array length = ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        Console.WriteLine();

        //insert sum
        Console.Write("Insert sum = ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //insert array' elements
        for (int elem = 0; elem < length; elem++)
        {
            Console.Write("Element [{0}] = ", elem);
            array[elem] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int start = 0;
        int end = 0;
        bool sumFound = false;

        for (int i = 0; i < array.Length && !sumFound; i++)
        {
            sum = array[i];
            //if single element is equal to sum
            if (sum == s)
            {
                start = i;
                end = i;
                break;
            }
            for (int j = i + 1; j < array.Length; j++)
            {
                if (sum < s)
                {
                    sum += array[j];
                }
                if (sum == s)
                {
                    start = i;
                    end = j;
                    //we want to find first elements that meet the requirement and exit the loop
                    sumFound = true;
                    break;
                }
                if (sum > s)
                {
                    break;
                }
            }
            sum = 0;
        }

        Console.Write("Start position: {0}", start);
        Console.Write("\nEnd position: {0}", end);
        Console.WriteLine();

        //print selected array
        for (int elem = start; elem <= end; elem++)
        {
            if (elem != end)
            {
                Console.Write("{0}, ", array[elem]);
            }
            else
            {
                Console.Write("{0}", array[elem]);
            }
        }
        Console.WriteLine();
    }
}
