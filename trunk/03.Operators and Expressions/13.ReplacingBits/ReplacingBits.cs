//13.Write a program that exchanges bits 3, 4 and 5 with bits 24, 25
//and 26 of given 32-bit unsigned integer
using System;

class ReplacingBits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        byte position1 = 3;
        byte position2 = 24;
        uint m = 7;
        uint mask1 = m << position1;
        uint mask2 = m << position2;
        uint getNumbers1 = number & mask1;
        uint getNumbers2 = number & mask2;
        uint change = (number & ~mask1) & ~mask2;
        uint mask3 = (getNumbers1 >> position1) << position2;
        uint mask4 = (getNumbers2 >> position2) << position1;
        uint result = (change | mask3) | mask4;
        Console.WriteLine(result);
    }
}