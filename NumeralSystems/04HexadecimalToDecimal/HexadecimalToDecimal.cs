//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static int HexadecimalToDecimalNumber(string hexadecimalNumber)
    {
        int decimalNumber = 0;
        int basePow = 1;
        int multiplier = 1;
        int addent = 0;
        int count = 0;
        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(hexadecimalNumber[hexadecimalNumber.Length - 1 - i]))
            {
                switch (hexadecimalNumber[hexadecimalNumber.Length - 1 - i])
                {
                    case 'A':
                        multiplier = 10;
                        break;
                    case 'B':
                        multiplier = 11;
                        break;
                    case 'C':
                        multiplier = 12;
                        break;
                    case 'D':
                        multiplier = 13;
                        break;
                    case 'E':
                        multiplier = 14;
                        break;
                    case 'F':
                        multiplier = 15;
                        break;
                }
            }
            else if (char.IsDigit(hexadecimalNumber[hexadecimalNumber.Length - 1 - i]))
            {
                multiplier = (int)Char.GetNumericValue(hexadecimalNumber[hexadecimalNumber.Length - 1 - i]);
            }
             
            count = i;
            while (count > 0)
            {
                basePow *= 16;
                count--;
            }

            addent += multiplier * basePow;
            decimalNumber += addent;
            addent = 0;
            basePow = 1;
        }

        return decimalNumber;
    }

    static void Main()
    {
        Console.WriteLine("Insert hexadecimal number");
        string hexadecimalNumber = Console.ReadLine();
        int decimalNumber = HexadecimalToDecimalNumber(hexadecimalNumber);
        Console.WriteLine("Hexadecimal number {0} in decimal format is {1}", hexadecimalNumber,decimalNumber);
    }
}
