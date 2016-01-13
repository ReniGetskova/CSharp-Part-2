using System;

// Write a program that finds the maximal sequence of equal elements in an array.

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Program that finds maximal sequence of equal elements in an array");
        //int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        //insert length and array
        Console.Write("\nPlease insert array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int len = 1;
        int end = 0;
        int bestLen = 1;
        int bestStart = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i])
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

        Console.WriteLine("Best start: {0}", bestStart);
        Console.WriteLine("Best length: {0}", bestLen);

        int tempLength = (bestStart + bestLen) - 1;
        //print selected part from the array
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
