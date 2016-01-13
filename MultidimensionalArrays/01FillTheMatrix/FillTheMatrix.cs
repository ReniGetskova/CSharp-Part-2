// Write a program that fills and prints a matrix of size (n, n) 
/*
a)	
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16

b)
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13

c)
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10

d)
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
*/

using System;

class FillTheMatrix
{
    static void Main()
    {
        //Console.Write("Insert number of rows and col for the square matrix: n = ");
        //int size = int.Parse(Console.ReadLine());

        int size = 4;
        int[,] matrix = new int[size, size];

        //fill matrix a)
        FillMatrixVertically(matrix);
        //print matrix a)
        Console.WriteLine("a)");
        PrintMatrix(matrix);
        //clear matrix a)
        ClearMatrix(matrix);

        //fill matrix b)
        FillMatrixVerticallyLikeSnake(matrix);
        //print matrix b)
        Console.WriteLine("b)");
        PrintMatrix(matrix);
        //clear matrix b)
        ClearMatrix(matrix);

        //fill matrix c)
        FillMatrixDiagonally(matrix);
        //print matrix c)
        Console.WriteLine("c)");
        PrintMatrix(matrix);
        //clear matrix c)
        ClearMatrix(matrix);

        //fill matrix d)
        FillMatrixSpirally(matrix);
        //print matrix d)
        Console.WriteLine("d)");
        PrintMatrix(matrix);
        //clear matrix d)
        ClearMatrix(matrix);

        //Console.WriteLine();
        //testDiagonals(matrix);
        //PrintMatrix(matrix);
    }

    static void ClearMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = 0;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }

    static void FillMatrixVertically(int[,] matrix)
    {
        int number = 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[col, row] = number++;
            }
        }
    }

    static void FillMatrixVerticallyLikeSnake(int[,] matrix)
    {
        int number = 1;
        int size = matrix.GetLength(0);
        for (int row = 0; row < matrix.GetLength(0); ++row)
        {
            int col = 0;
            for (; col < matrix.GetLength(1); col++)
            {
                if (row % 2 == 0)
                {
                    matrix[col, row] = number++;
                }
                else
                {
                    matrix[col, row] = number--;
                }
            }

            number = matrix[col - 1, row] + size;
        }
    }

    static void FillMatrixDiagonally(int[,] matrix)
    {
        int number = 1;
        int size = matrix.GetLength(0);
        for (int row = size - 1; row >= 0; row--)
        {
            for (int col = 0; col < size - row; col++)
            {

                matrix[row + col, col] = number++;
            }
        }
        for (int col = 1; col < size; col++)
        {
            for (int row = 0; row < size - col; row++)
            {
                matrix[row, col + row] = number++;
            }
        }
    }

    static void FillMatrixSpirally(int[,] matrix)
    {
        int number = 1;
        int size = matrix.GetLength(0) - 1;
        for (int index = 0; index < size ; index++)
        {
            for (int row = index; row < size - index; row++)
            {
                matrix[row, index] = number++;
            }
            for (int col = index; col < size - index; col++)
            {
                matrix[size - index, col] = number++;
            }
            for (int row = size - index; row > index; row--)
            {
                matrix[row, size - index] = number++;
            }
            for (int col = size - index; col > index; col--)
            {
                matrix[index, col] = number++;
            }
        }
    }

    static void testDiagonals(int[,] matrix)
    {
        int number = 1;
        int size = matrix.GetLength(0);
        int previousCol = size - 1;

        for (int row = 0; row < size; row++)
        {
            for (int currentCol = previousCol; currentCol < size; currentCol++)
            {
                matrix[row, currentCol] = number++;
            }
            previousCol--;
        }
    }
}
