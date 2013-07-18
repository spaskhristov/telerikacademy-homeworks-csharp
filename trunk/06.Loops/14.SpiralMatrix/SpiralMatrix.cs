// 14.Write a program that reads a positive integer number N (N < 20) 
// from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter the number of the rows and columns: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0, column = 0, rowOffset = 0;
        int columnOffset = 1, count = 0;
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                matrix[rows, cols] = 0;
            }
        }
        while (matrix[row, column] == 0)
        {
            matrix[row, column] = ++count;
            if (row + rowOffset > n - 1 ||
                row + rowOffset < 0 ||
                column + columnOffset > n - 1 ||
                column + columnOffset < 0 ||
                matrix[row + rowOffset, column + columnOffset] > 0)
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
            column += columnOffset;
        }
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("	" + matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}