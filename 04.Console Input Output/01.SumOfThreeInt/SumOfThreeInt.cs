//1.Write a program that reads 3 integer numbers from the console and prints their sum.
using System;

class SumOfThreeInt
{
    static void Main()
    {
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter {0} number: ", (i + 1));
            int a = int.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine("Sum: " + sum);
    }
}