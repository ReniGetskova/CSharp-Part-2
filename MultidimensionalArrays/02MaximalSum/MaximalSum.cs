// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that 
//has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        int rowNumber;
        int colNumber;
        do
        {
            Console.Write("Insert number of rows: ");
            rowNumber = int.Parse(Console.ReadLine());
            Console.Write("Insert number of cols: ");
            colNumber = int.Parse(Console.ReadLine());
        } while (rowNumber < 3 && colNumber < 3);
        int[,] matrix = new int[rowNumber, colNumber];

        int bestSum = int.MinValue;
        int sum;
        int bestRow = 0;
        int bestCol = 0;

        //fill matrix
        Console.WriteLine("Insert each row on one line with single space between numbers like: x x x x");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string colLine = Console.ReadLine();
            string[] cells = colLine.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                //Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = int.Parse(cells[col]);
            }
        }

        //test data
        //int[,] matrix = {
        //                    {7, 1, 3, 3, 2, 1},
        //                    {1, 3, 9, 8, 5, 6},
        //                    {4, 6, 7, 9, 1, 0},
        //                    {5, 8, 1, 4, 2, 3},
        //                    {1, 2, 3, 1, 4, 0}
        //                };

        //print the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }

        //find the suqre that has maximal sum
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                      matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                      matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (bestSum < sum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Best sum: {0}", bestSum);
        Console.WriteLine("Best row: {0}", bestRow);
        Console.WriteLine("Best col: {0}", bestCol);
        //print small matrix 3x3
        Console.WriteLine("Best matrix");
        Console.WriteLine(matrix[bestRow, bestCol] + ", " + matrix[bestRow, bestCol + 1] + ", " + matrix[bestRow, bestCol + 2]);
        Console.WriteLine(matrix[bestRow + 1, bestCol] + ", " + matrix[bestRow + 1, bestCol + 1] + ", " + matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine(matrix[bestRow + 2, bestCol] + ", " + matrix[bestRow + 2, bestCol + 1] + ", " + matrix[bestRow + 2, bestCol + 2]);
    }
}

