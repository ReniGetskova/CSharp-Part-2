//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Text;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Insert expression");
        string expression = Console.ReadLine();
        bool isCorrect = true;
        int leftBracketCount = 0;
        int rightBracketCount = 0;
        if (expression[0] == ')' || expression[expression.Length - 1] == '(')
        {
            isCorrect = false;
        }

        for (int i = 0; i < expression.Length && isCorrect == true; i++)
        {
            if (expression[i] == '(')
            {
                leftBracketCount++;
            }
            else if (expression[i] == ')')
            {
                rightBracketCount++;
            }
        }

        if (leftBracketCount == rightBracketCount && leftBracketCount != 0 && rightBracketCount != 0)
        {
            isCorrect = true;
            Console.WriteLine("Brackets are put correctly? -> {0}", isCorrect);
        }
        else
        {
            isCorrect = false;
            Console.WriteLine("Brackets are put correctly? -> {0}", isCorrect);
        }
    }
}
