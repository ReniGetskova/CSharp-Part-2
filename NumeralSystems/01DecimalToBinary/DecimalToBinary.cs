//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static string DecimalToBinaryNumber(int decimalNumber)
    {
        string binaryNumber = string.Empty;
        string binaryNumberRevert = string.Empty;
        int reminder;
        while (decimalNumber > 0)
        {
            reminder = decimalNumber % 2;
            decimalNumber /= 2;
            binaryNumber += reminder;
        }
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            binaryNumberRevert += binaryNumber[i];
        }

        return binaryNumberRevert;
    }
    static void Main()
    {
        Console.WriteLine("Insert decimal number");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binarynumber = DecimalToBinaryNumber(decimalNumber);
        Console.WriteLine("Decimal number {0} in binary format is: {1}", decimalNumber, binarynumber);
    }
}
