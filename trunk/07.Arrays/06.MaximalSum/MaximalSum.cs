/*6.Write a program that reads two integer numbers N and K and 
 * an array of N elements from the console. Find in the array 
 * those K elements that have maximal sum.*/
using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter the array length N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K (K < N): ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array [{0}] =  ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int start = 0;
        int bestStart = 0;
        int sum = 0;
        int sumJ = 0;
        int sumKJ = 0;
        int bestSum = 0;
        int maxSum = int.MinValue;
        if (k < n)
        {
            for (int i = 0; i < k; i++)
            {
                sum += array[i];
            }
            for (int j = 0; j < array.Length; j++)
            {
                start++;
                if (k + j == n) 
                    break;
                sumJ += array[j];
                sumKJ += array[k + j];
                bestSum = sum - sumJ + sumKJ;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestStart = 0;
                }
                if (bestSum > maxSum)
                {
                    maxSum = bestSum;
                    bestStart = start;
                }
            }
            Console.WriteLine();
            for (int i = bestStart; i < bestStart + k; i++)
            {
                Console.WriteLine("array [{0}] = {1}", i, array[i]);
            }
            Console.WriteLine("Maximal sum is: " + maxSum);
        }
        else Console.WriteLine("K > N Error!!!");
    }
}