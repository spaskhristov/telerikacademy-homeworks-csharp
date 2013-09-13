//2.Write a program to convert binary numbers to their decimal representation.
using System;
using System.Globalization;

class Base2toBase10
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        char[] binary = Console.ReadLine().ToCharArray();
        Array.Reverse(binary);
        int decNum = 0;
        int power = 1;
        Console.Write("Number in decimal: ");
        foreach (int ch in binary)
        {
            decNum += (ch - '0') * power;
            power = power << 1;
        }
        Console.WriteLine(decNum);
    }
}