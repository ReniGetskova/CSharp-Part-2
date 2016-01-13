//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static int BinaryToDecimalNumber(string binaryNumber)
    {
        int decimalNumber = 0;
        int basePow = 1;
        int count = 0;
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            if (binaryNumber[(binaryNumber.Length -1) - i] == '1')
            {
                count = i;
                while (count > 0)
                {
                    basePow *= 2 ;
                    count--;
                }

                decimalNumber += basePow;
                basePow = 1;
            }
        }

        return decimalNumber;
    }

    static void Main()
    {
        Console.WriteLine("Insert binary number");
        string binaryNumber = Console.ReadLine();
        int decimalNumber = BinaryToDecimalNumber(binaryNumber);
        Console.WriteLine("Binary number {0} in decimal format is {1}", binaryNumber, decimalNumber);
    }
}
