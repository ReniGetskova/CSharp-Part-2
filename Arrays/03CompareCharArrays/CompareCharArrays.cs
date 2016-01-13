using System;

// Write a program that compares two char arrays lexicographically (letter by letter).
class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Program that compare two arrays lexicographically");
        Console.Write("\nPlease insert first array: ");
        string firstArray = Console.ReadLine();
        Console.Write("Please insert second array: ");
        string secondArray = Console.ReadLine();
        bool areEqual = false;
        string biggerArray;
        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("Not equal length! Bigger array is: {0}", firstArray);
        }
        else if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("Not equal length! Bigger array is: {0}", secondArray);
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                areEqual = false;
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("Equal length! Lexicographically bigger array is {0}", firstArray);
                    return;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("Equal length! Lexicographically bigger array is {0}", secondArray);
                    return;
                }
                else
                {
                    areEqual = true;
                }
            }
            Console.WriteLine("Equal? -> {0}", areEqual);
        }
    }
}
