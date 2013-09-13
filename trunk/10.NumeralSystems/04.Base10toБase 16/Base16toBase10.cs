//4.Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Globalization;

class Base16toBase10
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        char[] hexadecimal = Console.ReadLine().ToCharArray();
        Array.Reverse(hexadecimal);
        int decNum = 0;
        int power = 1;
        int numHex = 0;
        Console.Write("Number in decimal: ");
        foreach (int ch in hexadecimal)
        {
            if (ch >= 'A') 
                numHex = ch - 'A' + 10;
            else 
                numHex = ch - '0';
            decNum += numHex * power;
            power = power << 4;
        }
        Console.WriteLine(decNum);
    }
}
