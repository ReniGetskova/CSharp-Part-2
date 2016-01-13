// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
// neighbour elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SequenceNmatrix
{
    static void Main()
    {
        //test data
        string[,] bigMatrix = {
                               {"ha", "fifi", "ho", "hi"},
                               {"fo", "ha", "hi", "xx"},
                               {"xxx", "ho", "ha", "xx"}
                           };

        //string[,] bigMatrix = {
        //                       {"s", "qq", "s"},
        //                       {"pp", "pp", "s"},
        //                       {"pp", "qq", "s"}
        //   };

        //print matrix
        for (int row = 0; row < bigMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < bigMatrix.GetLength(1); col++)
            {
                Console.Write("{0, 6}", bigMatrix[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        string resultCell = string.Empty;
        int sequence = 1;
        int bestSequence = 1;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row <= bigMatrix.GetLength(0) - 1; row++)
        {
            int col = 0;
            for (; col <= bigMatrix.GetLength(1) - 1; col++)
            {
                if (row == bigMatrix.GetLength(0) - 1 && col != bigMatrix.GetLength(1) - 1)
                {
                    if (bigMatrix[row, col] == bigMatrix[row, col + 1])
                    {
                        sequence++;

                    }
                }
                else if (col == bigMatrix.GetLength(1) - 1 && row != bigMatrix.GetLength(0) - 1)
                {
                    if (bigMatrix[row, col] == bigMatrix[row + 1, col])
                    {
                        sequence++;
                    }
                }
                else if (row != bigMatrix.GetLength(0) - 1 && col != bigMatrix.GetLength(1) - 1)
                {
                    if (bigMatrix[row, col] == bigMatrix[row, col + 1])
                    {
                        sequence++;
                    }
                    else if (bigMatrix[row, col] == bigMatrix[row + 1, col])
                    {
                        sequence++;
                    }
                    else if (bigMatrix[row, col] == bigMatrix[row + 1, col + 1])
                    {
                        sequence = bestSequence;
                        sequence++;
                    }
                }
                if (bestSequence < sequence)
                {
                    bestSequence = sequence;
                    sequence = 1;
                    resultCell = bigMatrix[row, col];
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("Best row: {0}", bestRow);
        Console.WriteLine("Best col: {0}", bestCol);
        Console.WriteLine("Best sequence: {0}", bestSequence);
        while (bestSequence > 0)
        {
            Console.Write(resultCell + " ");
            bestSequence--;
        }

        Console.WriteLine();
    }
}
