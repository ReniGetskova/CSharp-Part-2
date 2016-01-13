//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static int GetMax(int a, int b)
    {
        if (a >= b)
            return a;
        else 
            return b;
    }
    static void Main()
    {
        Console.WriteLine("Insert three integer numbers");
        int a, b, c;
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = int.Parse(Console.ReadLine());

        int max = GetMax(GetMax(a, b), c);
        Console.WriteLine("Max number = {0}", max);
    }
}
