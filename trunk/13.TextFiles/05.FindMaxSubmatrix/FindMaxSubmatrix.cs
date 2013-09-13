/*5.Write a program that reads a text file containing a square matrix of numbers
 * and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
 * The first line in the input file contains the size of matrix N. Each of the next N 
 * lines contain N numbers separated by space. The output should be a single number
 * in a separate text file. Example:
 * 4
 * 2 3 3 4
 * 0 2 3 4	 ----->		17
 * 3 7 1 2
 * 4 3 3 2 */
using System;
using System.IO;

class FindMaxSubmatrix
{
    static int[,] matrix;
    static int[,] GetMatrix(string filePath)
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            int n = int.Parse(input.ReadLine());
            matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = input.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    matrix[i, j] = int.Parse(numbers[j]);
            }
        }
        return matrix;
    }
    static void Main()
    {
        string filePath = "../../input.txt";
        int[,] matrix = GetMatrix(filePath);
        using (StreamWriter output = new StreamWriter("../../output.txt"))
            output.WriteLine(GetBestSum(matrix));
        using (StreamReader output = new StreamReader("../../output.txt"))
        {
            int bestSum = int.Parse(output.ReadLine());
            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
    }
    static int GetBestSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1]  +
                matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        return bestSum;
    }
}
