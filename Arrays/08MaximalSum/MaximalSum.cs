//Write a program that finds the sequence of maximal sum in given array.

using System;
class MaximalSum
{
    static void Main(string[] args)
    {
        //test data
        //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //int[] array = { 1, -2, -5, 100, -10, -20 };
        //int[] array = { -2, 10, -1, 3, -4, -9, 8, 3 };

        Console.Write("Array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }


        int maxSum = array[0];
        int start = 0;
        int end = 0;
        int currentSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                currentSum = currentSum + array[j];

                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    start = i;
                    end = j;
                    //for the second test case
                    if (maxSum < array[j])
                    {
                        maxSum = array[j];
                        start = j;
                        end = j;
                    }
                }
            }
        }
        Console.WriteLine("Start position: {0}", start);
        Console.WriteLine("End position: {0}", end);
        while (start != end + 1)
        {
            if (start == end)
            {
                Console.Write("{0}", array[start]);
            }
            else
            {
                Console.Write("{0}, ", array[start]);
            }
            start++;
        }
        Console.WriteLine();
    }
}
