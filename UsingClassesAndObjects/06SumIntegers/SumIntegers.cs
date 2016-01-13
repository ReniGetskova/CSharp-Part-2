//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;

class SumIntegers
{
    static int SumOfNumbers(string numbers)
    {
        int sum = 0;
        string[] separateNumbers = numbers.Split(' ');
        for (int i = 0; i < separateNumbers.Length; i++)
        {
            sum += int.Parse(separateNumbers[i]);
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Insert numbers on one line separate with single space");
        string inputNumbers = Console.ReadLine();
        int sum = SumOfNumbers(inputNumbers);
        Console.WriteLine("Sum of numbers is: {0}", sum);
    }
}
