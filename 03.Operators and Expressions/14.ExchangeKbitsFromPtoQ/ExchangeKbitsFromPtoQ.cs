//14.Write a program that exchanges bits {p, p+1, …, p+k-1) with bits
//{q, q+1, …, q+k-1} of given 32-bit unsigned integer.
using System;

class ExchangeKbitsFromPtoQ
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.Write("Enter a P: ");
        byte pos1 = byte.Parse(Console.ReadLine());
        Console.Write("Enter a Q: ");
        byte pos2 = byte.Parse(Console.ReadLine());
        Console.Write("Enter a K: ");
        int k = int.Parse(Console.ReadLine());
        uint m = 0;
        uint oneNumber = 1;
        for (int i = 0; i < k; i++)
        {
            m ^= oneNumber << i;
        }
        uint mask1 = m << pos1;
        uint mask2 = m << pos2;
        uint getNumbers1 = number & mask1;
        uint getNumbers2 = number & mask2;
        uint change = (number & ~mask1) & ~mask2;
        uint mask3 = (getNumbers1 >> pos1) << pos2;
        uint mask4 = (getNumbers2 >> pos2) << pos1;
        uint result = (change | mask3) | mask4;
        Console.WriteLine(result);
    }
}
