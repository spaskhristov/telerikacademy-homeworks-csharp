//7.Write a program that finds the greatest of given 5 variables.
using System;

class GreatNum
{
    static void Main()
    {
        double [] num = new double[5];
        double Max = 0D;
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("x{0}: ", i + 1);
            num[i] = double.Parse(Console.ReadLine());
            if (Max < num[i])
                Max = num[i];
        }
        Console.Write("Maximum = {0}\n", Max);
    }
}
