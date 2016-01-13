//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;
using System.Collections.Generic;
using System.Linq;
class SubsetWithSumS
{
    static void Main()
    {
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int s = 14;
        var sums = CalculateSum(numbers);

        foreach (var sum in sums)
        {
            if (sum == s)
            {
                Console.WriteLine("Yes: {0}", sum);
                break;
            }
        }
    }

    private static IEnumerable<int> CalculateSum(int [] numbers)
    {
        //min sum is negative number
        int minSum = numbers.Where(n => n < 0).Sum();
        int maxSum = numbers.Where(n => n > 0).Sum();
        //add offset to work with negative numbers
        int offset = -1 * minSum;

        //maxSum is posible sum so array length is + 1
        bool[] possibleSums = new bool[maxSum + offset + 1];
        possibleSums[offset] = true;

        foreach (int number in numbers)
        {
            //it's important to start from end
            for (int i = maxSum; i >= 0; i--)
            {
                if (possibleSums[offset + i])
                {
                    possibleSums[offset + i + number] = true;
                }
            }
        }

        var sums = new List<int>();
        for (int i = 0; i < possibleSums.Length; i++)
        {
            if (possibleSums[i])
            {
                sums.Add(i - offset);
            }
        }

        return sums;
    }
}
