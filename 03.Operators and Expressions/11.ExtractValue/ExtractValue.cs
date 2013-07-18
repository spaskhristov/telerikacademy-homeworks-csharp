//11.Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
using System;

class ExtractValue
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
        Console.WriteLine("Bit on position {0} is: {1}", p, bit);
    }
}
