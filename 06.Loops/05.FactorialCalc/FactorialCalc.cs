//5.Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
using System;

class FactorialCalc
{
    static void Main()
    {
        Console.WriteLine("Enter N and K (1 < N < K) : ");
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        int k = int.Parse(Console.ReadLine());
        decimal result;
        decimal sum1 = 1;
        decimal sum2 = 1;
        if (n > k && n < 1)
        {
            Console.WriteLine("Error !!!");
        }
        else
        {
            for (int i = (k - n + 1); i <= n; i++)
            {
                sum1 *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                sum2 *= j;
            }
            result = sum1 * sum2;
            Console.WriteLine("{1}!*{2}! / ({2}-{1})! = {0}", result, n, k);
        }
    }
}