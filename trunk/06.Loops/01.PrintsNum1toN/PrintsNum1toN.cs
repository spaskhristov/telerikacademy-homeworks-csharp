//1.Write a program that prints all the numbers from 1 to N.
using System;

class PrintsNum1toN
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.Write("{0}; ", i);
        }
        Console.WriteLine();
    }
}