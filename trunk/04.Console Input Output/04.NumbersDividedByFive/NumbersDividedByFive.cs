/* 4.Write a program that reads two positive integer numbers 
 * and prints how many numbers p exist between them such 
 * that the reminder of the division by 5 is 0 (inclusive). 
 * Example: p(17,25) = 2.*/
using System;

class NumbersDividedByFive
{
    static void Main()
    {
        Console.Write("Enter first positive integer: ");
        int int1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second positive integer: ");
        int int2 = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = Math.Min(int1, int2); i <= Math.Max(int1, int2); i++)
        {
            if (i % 5 == 0)
                count++;
        }
        Console.WriteLine("p({0} ,{1}) = {2}", int1, int2, count);
    }
}