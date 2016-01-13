//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static string BinaryToHexadecimalNumber(string binaryNumber)
    {
        string hexadecimalNumber = string.Empty;
        string binaryPiece = string.Empty;
        string hexadecimalPiece = string.Empty;
        int reminder = binaryNumber.Length % 4;
        string binaryAddZeros = string.Empty;
        if ( reminder == 0)
        {
            for (int i = 0; i < binaryNumber.Length; i += 4)
            {
                for (int j = i; j < i + 4; j++)
                {
                    binaryPiece += binaryNumber[j];
                }
                switch (binaryPiece)
                {
                    case "0000":
                        hexadecimalPiece += "0";
                        break;
                    case "0001":
                        hexadecimalPiece += "1";
                        break;
                    case "0010":
                        hexadecimalPiece += "2";
                        break;
                    case "0011":
                        hexadecimalPiece += "3";
                        break;
                    case "0100":
                        hexadecimalPiece += "4";
                        break;
                    case "0101":
                        hexadecimalPiece += "5";
                        break;
                    case "0110":
                        hexadecimalPiece += "6";
                        break;
                    case "0111":
                        hexadecimalPiece += "7";
                        break;
                    case "1000":
                        hexadecimalPiece += "8";
                        break;
                    case "1001":
                        hexadecimalPiece += "9";
                        break;
                    case "1010":
                        hexadecimalPiece += "A";
                        break;
                    case "1011":
                        hexadecimalPiece += "B";
                        break;
                    case "1100":
                        hexadecimalPiece += "C";
                        break;
                    case "1101":
                        hexadecimalPiece += "D";
                        break;
                    case "1110":
                        hexadecimalPiece += "E";
                        break;
                    case "1111":
                        hexadecimalPiece += "F";
                        break;
                }
                binaryPiece = string.Empty;
                hexadecimalNumber += hexadecimalPiece;
                hexadecimalPiece = string.Empty;
            }
        }
        else
        {
            while (reminder > 0)
            {
                binaryNumber = binaryNumber.Insert(0, "0");
                reminder--;
            }

            for (int i = 0; i < binaryNumber.Length; i += 4)
            {
                for (int j = i; j < i + 4; j++)
                {
                    binaryPiece += binaryNumber[j];
                }

                switch (binaryPiece)
                {
                    case "0000":
                        hexadecimalPiece += "0";
                        break;
                    case "0001":
                        hexadecimalPiece += "1";
                        break;
                    case "0010":
                        hexadecimalPiece += "2";
                        break;
                    case "0011":
                        hexadecimalPiece += "3";
                        break;
                    case "0100":
                        hexadecimalPiece += "4";
                        break;
                    case "0101":
                        hexadecimalPiece += "5";
                        break;
                    case "0110":
                        hexadecimalPiece += "6";
                        break;
                    case "0111":
                        hexadecimalPiece += "7";
                        break;
                    case "1000":
                        hexadecimalPiece += "8";
                        break;
                    case "1001":
                        hexadecimalPiece += "9";
                        break;
                    case "1010":
                        hexadecimalPiece += "A";
                        break;
                    case "1011":
                        hexadecimalPiece += "B";
                        break;
                    case "1100":
                        hexadecimalPiece += "C";
                        break;
                    case "1101":
                        hexadecimalPiece += "D";
                        break;
                    case "1110":
                        hexadecimalPiece += "E";
                        break;
                    case "1111":
                        hexadecimalPiece += "F";
                        break;
                }

                binaryPiece = string.Empty;
                hexadecimalNumber += hexadecimalPiece;
                hexadecimalPiece = string.Empty;
            }
        }
       
        return hexadecimalNumber;
    }

    static void Main()
    {
        Console.WriteLine("Insert binary number");
        string binaryNumber = Console.ReadLine();
        string hexadecimalNumber = BinaryToHexadecimalNumber(binaryNumber);
        Console.WriteLine("Binary number {0} in hexadecimal format is {1}", binaryNumber, hexadecimalNumber);
    }
}
