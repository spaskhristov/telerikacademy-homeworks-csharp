// 7.Write a program that gets a number n and after that gets 
// more n numbers and calculates and prints their sum. 
using System;

class Sum
{
    static void Main()
    {
        Console.WriteLine("Enter number N for summing");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("x{0} = ", (i+1));
            double x = double.Parse(Console.ReadLine());
            sum += x;
        }
        Console.WriteLine("Sum is: " + sum);
    }
}
