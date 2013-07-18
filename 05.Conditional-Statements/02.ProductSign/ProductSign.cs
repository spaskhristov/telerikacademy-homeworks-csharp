//2.Write a program that shows the sign (+ or -) of the product of three
//real numbers without calculating it. Use a sequence of if statements.
using System;

class ProductSign
{
    static void Main()
    {
        int[] num = new int[3];
        int sign = 1;
        for (int i = 0; i < 3; i++)
        {
            Console.Write("x{0}: ", i + 1);
            num[i] = int.Parse(Console.ReadLine());
            sign *= Math.Sign(num[i]);
        }
        if (sign == 0)
        {
            Console.WriteLine("The product is ZERO!");
        }
        if (sign == -1)
        {
            Console.WriteLine("The product is NEGATIVE!");
        }
        if (sign == 1)
        {
            Console.WriteLine("The product IS POSITIVE!");
        }
    }
}