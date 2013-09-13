/*2.Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from the console and prints the biggest of
 * them using the method GetMax().*/
using System;

class FindMaxElement
{
    static int GetMax(int num1, int num2)
    {
        int max = num1;
        if (num1 < num2)
            max = num2;
        return max;
    }
    static void Main()
    {
        Console.Write("Enter num1 = ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter num2 = ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter num3 = ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Max number is: {0}", GetMax(GetMax(num1, num2), num3));
    }
}