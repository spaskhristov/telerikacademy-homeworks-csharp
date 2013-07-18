/*5.Write a program that gets two numbers from the console and prints 
 * the greater of them. Don’t use if statements. */
using System;

class MaxTwoInt
{
    static void Main()
    {
        Console.Write("Enter first positive integer: ");
        int int1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second positive integer: ");
        int int2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Bigger number is: " + Math.Max(int1, int2));
    }
}