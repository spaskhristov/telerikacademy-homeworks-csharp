//4. Write a program to print the numbers 1, 101 and 1001.
using System;

class PrintNumbers
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
                Console.WriteLine("1;");
            else
                Console.WriteLine("{0}1;", Math.Pow(10, i));
        }
    }
}