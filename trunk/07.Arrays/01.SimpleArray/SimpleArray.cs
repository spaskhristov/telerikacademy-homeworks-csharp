/*1.Write a program that allocates array of 20 integers 
 * and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console.*/
using System;

class SimpleArray
{
    static void Main()
    {
        int rows = 20;
        int[] array = new int[rows];
        int i = 0;
        for (int row = 0; row < rows; row++)
        {
            i = row * 5;
            Console.WriteLine("array [{0}] = {1} ", row, i);
        }
    }
}
