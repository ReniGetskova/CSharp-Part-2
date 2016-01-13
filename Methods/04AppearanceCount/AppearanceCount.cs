//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


using System;
class AppearanceCount
{
    static void CountNumberInArray(int number, params int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }

        Console.WriteLine("Number {0} appear {1} times in array: ", number, count);
        PrintArray(array);
    }
    static void PrintArray(params int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        //using key word params
        CountNumberInArray(3, 1, 2, 3, 4, 3, 5, 3, 6, 7, 3, 8, 3, 9, 10);
    }
}
