//9. Write a program to print the first 100 members of the sequence of 
// Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
using System;

class SequenceOfFibonacci
{
    static void Main()
    {
        ulong num1 = 0;
        ulong num2 = 1;
        ulong sum = 0;
        for (int counter = 0; counter < 100; counter++)
        {
            Console.WriteLine(num1);
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
        }
    }
}