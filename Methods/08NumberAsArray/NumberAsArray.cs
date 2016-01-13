//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] 
//contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Numerics;

class NumberAsArray
{
    static int[] FillArray(BigInteger number)
    {
        string numberToString = number.ToString();
        int numberLength = numberToString.Length;
        int[] array = new int[numberLength];
        for (int i = numberLength - 1; i >= 0; i--)
        {
            array[i] = (int)number % 10;
            number /= 10;
        }
        return array;
    }

    static int[] SumArrays(int[] firstArray, int[] secondArray)
    {
        int firstArrayLength = firstArray.Length;
        int secondArrayLength = secondArray.Length;
        int minLength = GetMin(firstArrayLength, secondArrayLength);
        int maxLength = GetMax(firstArrayLength, secondArrayLength);
        int sumByDigits = 0;
        int[] resultArray = new int[maxLength];
        for (int i = minLength - 1; i >= 0; i--)
        {
            sumByDigits += firstArray[i + (maxLength - minLength)] + secondArray[i];
            if (sumByDigits < 10)
            {
                resultArray[i + (maxLength - minLength)] = sumByDigits;
                sumByDigits = 0;
            }
            else
            {
                resultArray[i + (maxLength - minLength)] = sumByDigits % 10;
                sumByDigits = 1;
            }
        }
        //if second array is with smaller length we fill result array with elements from first array. Example 123 + 9
        for (int i = maxLength - minLength - 1; i >= 0; i--)
        {
                resultArray[i] = firstArray[i] + sumByDigits;
                sumByDigits = 0;
        }
        return resultArray;
    }

    static int GetMin(int a, int b)
    {
        if (a <= b)
            return a;
        else
            return b;
    }

    static int GetMax(int a, int b)
    {
        if (a >= b)
            return a;
        else
            return b;
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
        //BigInteger number = BigInteger.Pow(Int64.MaxValue, 2);
        BigInteger number1 = 299;
        BigInteger number2 = 187;
        int[] array1 = FillArray(number1);
        int[] array2 = FillArray(number2);
        PrintArray(array1);
        PrintArray(array2);
        int[] result = new int[GetMax(array1.Length, array2.Length)];
        result = SumArrays(array1, array2);
        PrintArray(result);
    }
}
