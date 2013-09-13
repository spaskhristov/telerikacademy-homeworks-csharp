/*13.Write a program that can solve these tasks:
 * Reverses the digits of a number
 * Calculates the average of a sequence of integers
 * Solves a linear equation a * x + b = 0
 *	Create appropriate methods.
 * 	Provide a simple text-based menu for the user to choose which task to solve.
 *	Validate the input data:
 * The decimal number should be non-negative
 * The sequence should not be empty
 * a should not be equal to 0*/
using System;

class ReverseAverageLinearEquation
{
    static void Main()
    {
        Console.WriteLine("1: Reverse Digits; 2: Get Average; 3: Calculate Equation");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1: Reverse(); break;
            case 2: Average(); break;
            case 3: Equation(); break;
            default: Console.WriteLine("Error!!!"); ; break;
        }
    }
    static void Reverse()
    {
        Console.Write("Enter number to reverse:");
        int num = int.Parse(Console.ReadLine());
        if (num < 10)
        {
            Console.Write(num);
        }
        else
        {
            for (int i = 1; ; i = i * 10)
            {
                int n = num / i % 10;
                if (num / i < 1)
                    break;
                Console.Write(n);
            }
        }
        Console.WriteLine();
    }
    static void Average()
    {
        Console.Write("Enter array size and numbers:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        double sum = 0;
        for (int i = 0; i < array.Length; i++) 
            sum += array[i];
        sum =  sum / array.Length;
        Console.WriteLine(sum);
    }
    static void Equation()
    {
        Console.Write("Enter A (A should not be zero): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());
        if (a != 0)
        {
            double c = (-b / a);
            Console.WriteLine("Calculate Equation: " + c);
        }
        else Console.WriteLine("Coefficient 'A' should not be zero.");
    }
}
