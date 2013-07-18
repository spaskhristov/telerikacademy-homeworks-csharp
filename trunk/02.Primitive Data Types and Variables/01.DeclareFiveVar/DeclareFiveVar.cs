/* 1.Declare five variables choosing for each of 
 * them the most appropriate of the types byte,
 * sbyte, short, ushort, int, uint, long, ulong 
 * to represent the following values: 52130, -115,
 * 4825932, 97, -10000. */
using System;

class DeclareFiveVar
{
    static void Main()
    {
        ushort u = 52130;
        sbyte s = -115;
        int i = 4825932;
        byte b = 97;
        short sh = -10000;
        Console.WriteLine(u);
        Console.WriteLine(s);
        Console.WriteLine(i);
        Console.WriteLine(b);
        Console.WriteLine(sh);
    }
}