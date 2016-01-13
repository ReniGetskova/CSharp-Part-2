//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first
//of the key, the second – with the second, etc. When the last key character is reached, the next is the first.


using System;
using System.Text;
class EncodeDecode
{
    static void Main()
    {
        string text;
        string cipher;
        do
        {
            Console.WriteLine("Insert text");
            text = Console.ReadLine();
            Console.WriteLine("Insert ciper");
            cipher = Console.ReadLine();

        } while (cipher.Length > text.Length);

        StringBuilder encodedText = new StringBuilder();
        //encode
        for (int i = 0; i < text.Length; i++)
        {
            int j = i % cipher.Length;
            encodedText.Append((char)(text[i] ^ cipher[j]));
        }

        string resultEncoded = encodedText.ToString();
        Console.WriteLine("From given text and cipher we get encoded text:");
        Console.WriteLine(resultEncoded);

        StringBuilder decodedText = new StringBuilder();
        //decode
        text = string.Empty;
        for (int i = 0; i < resultEncoded.Length; i++)
        {
            int j = i % cipher.Length;
            decodedText.Append((char)(encodedText[i] ^ cipher[j]));
        }

        string resultDecoded = decodedText.ToString();
        Console.WriteLine("From decoded text and cipher we get original text:");
        Console.WriteLine(resultDecoded);
    }
}
