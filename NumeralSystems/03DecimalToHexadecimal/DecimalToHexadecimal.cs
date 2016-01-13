//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static string DecimalToHexadecimalNumber(int decimalNumber)
    {
        string hexadecimalNumber = string.Empty;
        string hexadecimalReverse = string.Empty;
        string reminder = string.Empty;
        while (decimalNumber > 0)
        {
            reminder = (decimalNumber % 16).ToString();
            decimalNumber /= 16;
            switch (reminder)
            {
                case "10":
                    reminder = "A";
                    break;
                case "11":
                    reminder = "B";
                    break;
                case "12":
                    reminder = "C";
                    break;
                case "13":
                    reminder = "D";
                    break;
                case "14":
                    reminder = "E";
                    break;
                case "15":
                    reminder = "F";
                    break;
            }

            hexadecimalNumber += reminder;
        }

        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
            hexadecimalReverse += hexadecimalNumber[i];
        }

        return hexadecimalReverse;
    }

    static void Main()
    {
        Console.WriteLine("Insert decimal number");
        int decimalNumber = int.Parse(Console.ReadLine());
        string hexadecimalNumber = DecimalToHexadecimalNumber(decimalNumber);
        Console.WriteLine("Decimal number {0} in hexadecimal format is {1}", decimalNumber, hexadecimalNumber);
    }
}
