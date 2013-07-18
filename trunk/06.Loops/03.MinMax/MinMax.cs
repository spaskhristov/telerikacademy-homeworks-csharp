//3.Write a program that reads from the console a sequence of N integer numbers
//and returns the minimal and maximal of them.
using System;

class MinMax
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        int n = int.Parse(Console.ReadLine());
        int Maximum = 0;
        int Minimum = 0;
        int[] Numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter x{0}: ", i+1);
            Numbers[i] = int.Parse(Console.ReadLine());
        }
        Minimum = Numbers[0];
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (Minimum > Numbers[i])
                Minimum = Numbers[i];
            if (Maximum < Numbers[i])
                Maximum = Numbers[i];
        }
        Console.WriteLine("Minimum = {0}", Minimum);
        Console.WriteLine("Maximum = {0}", Maximum);
    }
}