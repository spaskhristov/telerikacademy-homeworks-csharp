// 9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
// Use Windows Character Map to find the Unicode code of the © symbol. 
// Note: the © symbol may be displayed incorrectly.
using System;

class CopyRightTriangle
{
    static void Main()
    {
        int rows = 3;
        char symbol = '\u00A9';
        char[,] tr = new char[rows, rows*2-1];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows*2-1; j++)
            {
                if ((j  <=rows*2 - 2 - i) && (j >= i))
                {
                    tr[i, j] = symbol;//fill Copy Right Triangle
                }
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows*2-1; j++)
            {
                Console.Write(tr[i, j]);// print Copy Right Triangle
            }
            Console.WriteLine();
        }
    }
}