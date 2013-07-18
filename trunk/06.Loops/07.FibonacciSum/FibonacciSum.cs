/*7.Write a program that reads a number N and calculates the sum of the first N
 * members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,
 * 144, 233, 377, …
 * Each member of the Fibonacci sequence (except the first two) is a sum of the
 * previous two members.*/
using System;

class FibonacciSum
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int num1 = 0;
        int num2 = 1;
        int num3 = 1;
        int sum = 0;
        if (n == 1) { sum = 0; Console.WriteLine(sum); }
        else
        {
            for (int i = 0; i < (n - 2); i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                sum += num2;
            }
            sum = sum + 1;
            Console.WriteLine(sum);
        }
    }
}