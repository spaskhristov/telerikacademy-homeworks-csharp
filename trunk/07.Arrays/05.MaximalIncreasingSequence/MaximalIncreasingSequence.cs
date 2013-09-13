/* 5.Write a program that finds the maximal
 * increasing sequence in an array. Example: 
 * {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
 */
using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array [{0}] =  ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int start = 0;
        int len = 1;
        int bestStart = 0, bestLen = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                start = i;
                len++;
                if (bestLen < len)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }
            else
            {
                len = 1;
            }
        }
        for (int j = bestStart - bestLen + 1; j <= bestStart; j++)
        {
            Console.Write(array[j] + " ");
        }
        Console.WriteLine();
    }
}