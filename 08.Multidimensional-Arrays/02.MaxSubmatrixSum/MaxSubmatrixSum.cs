//2.Write a program that reads a rectangular matrix of size N x M and finds in it 
//the square 3 x 3 that has maximal sum of its elements.
using System;

class MaxSubmatrixSum
{
    static void Main()
    {
        Console.Write("Enter the number of the rows: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the columns: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("matrix[{0},{1}] =  ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("The matrix:");
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("	" + matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The best platform is:");
        for (int r = bestRow; r < bestRow + 3; r++)
        {
            for (int c = bestCol; c < bestCol + 3; c++)
            {
                Console.Write("	" + matrix[r, c]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}