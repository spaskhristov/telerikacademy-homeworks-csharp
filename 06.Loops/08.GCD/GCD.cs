//8.Write a program that calculates the greatest common divisor (GCD)
//of given two numbers. Use the Euclidean algorithm (find it in Internet).
using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter B = ");
        int b = int.Parse(Console.ReadLine());
        int r = 0;
        int s = 0;
        int k = 0;
        double d = 0;
        bool b1 = false;
        bool b2 = false;
        while (a != b)
        {
            while (a % 2 == 0)
            {
                a = a / 2;
                r++;
                b1 = true;
            }
            while (b % 2 == 0)
            {
                b = b / 2;
                s++;
                b2 = true;
            }
            if (b1 && b2)
            {
                k = Math.Min(r, s);
                k = Math.Min(r, Math.Min(s, k));
            }
            if (a > b)
            {
                a = a - b;
            }
            if (a < b)
            {
                b = b - a;
                b1 = false;
                b2 = false;
            }
        }
        d = Math.Pow(2, k) * a;
        Console.WriteLine("The Greatest Common Divider is: {0}", d);
    }
}