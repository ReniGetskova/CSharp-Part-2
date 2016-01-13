//Write a program that finds the most frequent number in an array.

using System;
class FrequentNumber
{
    static void Main()
    {
        //test data
        //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        //insert array'length
        Console.Write("Array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        Console.WriteLine();

        //insert array' elements
        for (int elem = 0; elem < length; elem++)
        {
            Console.Write("Element [{0}] = ", elem);
            array[elem] = int.Parse(Console.ReadLine());
        }

        int frequentCounter = 1;
        int bigFrequentCouner = 0;
        int element = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == int.MinValue)
                {
                    continue;
                }
                if (array[i] == array[j])
                {
                    frequentCounter++;
                    array[j] = int.MinValue;
                }
                if (bigFrequentCouner < frequentCounter)
                {
                    bigFrequentCouner = frequentCounter;
                    element = array[i];
                }
            }
            frequentCounter = 1;
        }
        Console.WriteLine("{0} ({1} times)", element, bigFrequentCouner);
    }
}
