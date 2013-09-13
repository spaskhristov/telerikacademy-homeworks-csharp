//8.Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;

class BinaryRepresentation
{
    static void Main()
    {
        Console.Write("Enter short number: ");
        short inputShort = short.Parse(Console.ReadLine());  
        Console.Write("Number in binary: ");
        Console.WriteLine(GetBinary(inputShort));
    }
    static string GetBinary(short inputShort)
    {
        string num = "";
        for (int i = 0; i < 16; i++)
            num = (inputShort >> i & 1) + num;
        return num;
    }
}