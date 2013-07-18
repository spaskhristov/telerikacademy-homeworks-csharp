//4.Write a program that calculates N!/K! for given N and K (1<K<N).
using System;

class FactorialDiv
{
    static void Main()
    {
        Console.WriteLine("Enter N and K (1 < K < N) : ");
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        int k = int.Parse(Console.ReadLine());
        int result = 1;
        if (k > n)
        {
            Console.WriteLine(" k > n Error!!!");
        }
        else
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("{0}!/{1}! = {2}", n, k, result);
        }
    }
}