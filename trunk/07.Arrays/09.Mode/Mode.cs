/*9.Write a program that finds the most frequent 
 * number in an array. 
 * Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)*/
using System;

class Mode
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
        Array.Sort(array);
        int start = 0;
        int len = 1;
        int bestStart = 0, bestLen = 1;
        int bestLenElement = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                start = i;
                len++;
                if (bestLen < len)
                {
                    bestStart = start;
                    bestLenElement = array[bestStart];
                    bestLen = len;
                }
            }
            else
            {
                len = 1;
            }
        }
        if (len > bestLen)
        {
            bestLen = len;
            bestLenElement = array[array.Length - 1];
        }
        Console.WriteLine("{0} ({1} times)", bestLenElement, bestLen);
    }
}
