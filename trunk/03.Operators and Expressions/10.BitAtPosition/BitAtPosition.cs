//10.Write a boolean expression that returns if the bit at position 
//p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class BitAtPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position of bits: ");
        byte p = byte.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
