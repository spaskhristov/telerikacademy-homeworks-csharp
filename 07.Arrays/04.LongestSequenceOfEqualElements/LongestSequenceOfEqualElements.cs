/*4.Write a program that finds the maximal sequence of equal 
 * elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.*/
using System;

class LongestSequenceOfEqualElements
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
      	 			bestLen = len;
                    bestLenElement = array[start];
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
        for (int i = 0; i < bestLen; i++)
        {
            Console.Write(bestLenElement + " ");
        }
        Console.WriteLine();
	}
}
