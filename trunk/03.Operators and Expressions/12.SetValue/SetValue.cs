/*12.We are given integer number n, value v (v=0 or 1) and a position p.
Write a sequence of operators that modifies n to hold the value v at 
the position p from the binary representation of n.*/
using System;

class SetValue
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position of bits: ");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("Enter value 1 or 0: ");
        byte v = byte.Parse(Console.ReadLine());
        int mask;
        int result;
        if (v == 0)
        {
            mask = ~(1 << p);
            result = n & mask;
            Console.WriteLine(result);
        }
        else
        {
            mask = 1 << p;
            result = n | mask;
            Console.WriteLine(result);
        }
    }
}
