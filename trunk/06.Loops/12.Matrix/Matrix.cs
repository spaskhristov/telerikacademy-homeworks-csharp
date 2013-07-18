// 12. Write a program that reads from the console a positive integer 
// number N (N < 20) and outputs a matrix like the following:
using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col <= (row + n - 1); col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}