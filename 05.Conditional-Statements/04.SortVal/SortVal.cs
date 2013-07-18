//4.Sort 3 real values in descending order using nested if statements
using System;

class SortVal
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real number:");
        Console.Write("1 Number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("2 Number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("3 Number: ");
        int c = int.Parse(Console.ReadLine());
        int Min = Math.Min(a, Math.Min(b, c));
        int d = a;
        a = Min;
        if (Min == b)
        {
            b = d;
        }
        if (Min == c)
        {
            c = d;
        }
        if (b > c)
        {
            int f = b;
            b = c;
            c = f;
        }
        Console.WriteLine("1 Number = " + a);
        Console.WriteLine("2 Number = " + b);
        Console.WriteLine("3 Number = " + c);
    }
}

