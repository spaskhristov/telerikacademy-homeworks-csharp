//1.Write a program that fills and prints a matrix of size (n, n) 
// as shown below: (examples for n = 4)
using System;

class MatrixFour
{
    static void Main()
    {
        Console.Write("Enter the number of the rows and columns: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        PrintMatrixA(matrix);
        PrintMatrixB(matrix);
        PrintMatrixC(matrix);
        PrintMatrixD(matrix);
    }
    static void PrintMatrixA(int[,] matrix)
    {

        int count = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = ++count;
            }
        }
        Console.WriteLine("Matrix A:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("	" + matrix[j, i]);
            }
            Console.WriteLine();
        }
    }
    static void PrintMatrixB(int[,] matrix)
    {
        int count = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col == 0 || col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = ++count;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = ++count;
                }
            }
        }
        Console.WriteLine("Matrix B:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("	" + matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void PrintMatrixC(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int count = 0;
        int positionX = 0;
        int positionY = 0;
        int step = 0;
        for (int i = 1; i <= ((n * 2) - 1); i++)
        {
            if (i < n)
            {
                step++;
                for (int x = 0, y = step - 1; x < step; x++, y--)
                {
                    positionX = x;
                    positionY = y;
                    count++;
                    matrix[positionY, positionX] = count;
                }
            }
            if (i == n)
            {
                step = n;
                for (int x = 0, y = step - 1; x < step; x++, y--)
                {
                    positionX = x;
                    positionY = y;
                    count++;
                    matrix[positionY, positionX] = count;
                }
            }
            if (i > n)
            {
                step--;
                for (int x = n - step, y = n - 1; x < n; x++, y--)
                {
                    positionX = x;
                    positionY = y;
                    count++;
                    matrix[positionY, positionX] = count;
                }
            }
        }
        Console.WriteLine("Matrix C:");
        for (int row = n - 1; row >= 0; row--)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("	" + matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void PrintMatrixD(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 0;
            }
        }
        int row = 0, col = 0, rowOffset = 0;
        int columnOffset = 1, count = 0;
        while (matrix[row, col] == 0)
        {
            matrix[row, col] = ++count;
            if (row + rowOffset > matrix.GetLength(0) - 1 ||
                row + rowOffset < 0 ||
                col + columnOffset > matrix.GetLength(0) - 1 ||
                col + columnOffset < 0 ||
                matrix[row + rowOffset, col + columnOffset] > 0)
            {
                if (rowOffset == 0)
                {
                    rowOffset = columnOffset;
                    columnOffset = 0;
                }
                else
                {
                    columnOffset = -rowOffset;
                    rowOffset = 0;
                }
            }
            row += rowOffset;
            col += columnOffset;
        }
        Console.WriteLine("Matrix D:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("	" + matrix[j, i]);
            }
            Console.WriteLine();
        }
    }
}