﻿/* 13.Write a program that calculates for given N how many trailing zeros 
 * present at the end of the number N!. Examples:
 * N = 10 -> N! = 3628800 -> 2
 * N = 20 -> N! = 2432902008176640000 -> 4
 * Does your program work for N = 50 000?
 * Hint: The trailing zeros in N! are equal to the number of its prime
 * divisors of value 5. Think why!*/
using System;

class NumberOfZeros
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        int x = 5;
        double power = 1;
        double factorial = 1;
        double sum = 0;
        for (int k = 1; k <= n; k++)
        {
            if (n <= 1)
            {
                break;
            }
            factorial *= k;
            power *= x;
            sum = sum + (n / power);
        }
        Console.WriteLine("n! = " + factorial);
        Console.WriteLine("S = {0} ", (int)sum);
    }
}