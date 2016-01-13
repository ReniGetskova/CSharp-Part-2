//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        int countOfRandomNumbers = 10;
        Random generator = new Random();
        int randomNumber;
        while (countOfRandomNumbers > 0)
        {
            randomNumber = generator.Next(100, 201);
            Console.WriteLine(randomNumber);
            countOfRandomNumbers--;
        }
    }
}
