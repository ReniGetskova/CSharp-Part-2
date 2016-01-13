// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        // test data
        //int k = 3;
        //int n = 6;
        //int[] array = { 1, 3, 4, 5, 8, 2};

        //validate input if n > k
        Console.Write("Array length = ");
        int n = int.Parse(Console.ReadLine());
        int k;
        do
        {
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            
        } while (k > n);
        Console.WriteLine();

        //insert array
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int bigSum = 0;
        int start = -1;
        int end = 0;
        int bestStart = 0;
        int bestEnd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            //prevent from exit out of range
            if (end != array.Length - 1)
            {
                start++;
                end = (start + k) - 1;
                for (int j = start; j <= end; j++)
                {
                    sum += array[j];
                }
            }
            if (bigSum < sum)
            {
                bigSum = sum;
                bestStart = (end - k) + 1;
                bestEnd = end;
            }
            sum = 0;
        }

        Console.WriteLine("\nBig sum: {0}", bigSum);
        Console.WriteLine("Best start: {0}", bestStart);
        Console.WriteLine("Best end: {0}", bestEnd);
        Console.WriteLine();

        //print selected part from the array
        for (int i = bestStart; i <= bestEnd; i++)
        {
            if (i == bestEnd)
            {
                Console.Write("{0}", array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
        Console.WriteLine();
    }
}
