//1.Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;

class Base10toBase2
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        List<int> inBinary = new List<int>();
        while (number > 0)
        {
            inBinary.Add(number % 2);
            number = number / 2;
        }
        inBinary.Reverse();
        Console.Write("Number in binary: ");
        for (int i = 0; i < inBinary.Count; i++)
        {
            Console.Write("{0} ", inBinary[i]);
        }
        Console.WriteLine();
    }
}

