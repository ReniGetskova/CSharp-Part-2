using System;

// Write a program that finds the maximal increasing sequence in an array.

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Program that finds maximal increasing sequence in an array");
        //int[] array = { 3, 2, 3, 4, 2, 2, 4 };

        //insert array
        Console.Write("\nPlease insert array length: ");
        int lentgth = int.Parse(Console.ReadLine());
        int[] array = new int[lentgth];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int end = 0;
        int len = 1;
        int bestStart = 0;
        int bestLen = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] < array[i])
            {
                len++;
                if (bestLen < len)
                {
                    bestLen = len;
                    end = i + 1;
                    bestStart = end - bestLen;

                }
            }
            else
            {
                len = 1;
            }

        }
        Console.WriteLine("\nBest start position: {0}", bestStart);
        Console.WriteLine("Best length: {0}", bestLen);

        //print selected part from array
        int tempLength = (bestStart + bestLen) - 1;
        for (int i = bestStart; i <= tempLength; i++)
        {
            if (i != tempLength)
            {
                Console.Write("{0}, ", array[i]);
            }
            else
            {
                Console.Write("{0}", array[i]);
            }
        }
        Console.WriteLine();
    }
}
