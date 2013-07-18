//3.Write a program that finds the biggest of three integers using nested if statements.
using System;
using System.Linq;

class MaxOf3Num
{
    static void Main()
    {
        int[] num = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("x{0}: ", i + 1);
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Max number is: {0}", num.Max());
    }
}