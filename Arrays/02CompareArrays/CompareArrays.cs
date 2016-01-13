using System;

// Write a program that reads two integer arrays from the console and compares them element by element
class CompareArrays
{
    static void Main()
    {
        // two arrays are equal if they have equal length and their elements are equal
        Console.WriteLine("Program that compare two arrays\n");
        Console.Write("Insert length for first array: ");
        int firstArrayLength = int.Parse(Console.ReadLine());
        Console.Write("Insert length for second array: ");
        int secondArrayLength = int.Parse(Console.ReadLine());
      
        bool isEqual = true;
        if (firstArrayLength != secondArrayLength)
        {
            isEqual = false;
            Console.WriteLine("Equal? -> {0} ", isEqual);
            return;
        }
        else
        {
            int[] firstArray = new int[firstArrayLength];
            int[] secondArray = new int[secondArrayLength];
            Console.WriteLine("\nInsert elements for first array");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Element [{0}] = ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nInsert elements for second array");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("Element [{0}] = ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    Console.WriteLine("\nEqual? -> {0} ", isEqual);
                    return;
                }
            }
            Console.WriteLine("\nEqual? -> {0} ", isEqual);
        }

    }
}
