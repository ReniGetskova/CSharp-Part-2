//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of 
//Eratosthenes algorithm.

using System;
class PrimeNumbers
{
    static void Main()
    {
        int result = 0;
        for (int i = 2; i <= 10000000; i++)
        {
            if (i == 2)
            {
                Console.Write("{0}, ", i);
            }

            for (int j = 2; j < Math.Sqrt(i) + 1; j++)
            {
                result = i % j;
                if (result == 0)
                {
                    break;
                }
            }

            if (result != 0)
            {
                Console.Write("{0}, ", i);
            }         
        }
    }
}
