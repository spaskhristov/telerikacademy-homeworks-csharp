//6.Write a program that, for a given two integer numbers N and X,
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
using System;

class SumXandN
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x = ");
        int x = int.Parse(Console.ReadLine());
        decimal power = 1;
        decimal factorial = 1;
        decimal sum = 1;
        for (int i = 1; i <= n; i++)
        {
            if (n <= 1)
            {
                break;
            }
            factorial *= i;
            power *= x;
            sum = sum + (factorial / power);
        }
        Console.WriteLine("S = " + sum);
    }
}