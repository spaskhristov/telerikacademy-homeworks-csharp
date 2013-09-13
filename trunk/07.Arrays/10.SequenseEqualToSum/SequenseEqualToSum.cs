/*10.Write a program that finds in given array 
 * of integers a sequence of given sum S (if present).
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}*/
using System;

class SequenseEqualToSum
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
        Console.Write("S =  ");
        int givenSum = int.Parse(Console.ReadLine());
        int start = 0;
        int end = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum == givenSum)
                {
                    count++;
                    start = i;
                    end = j;
                    for (int v = start; v <= end; v++)
                    {
                        Console.Write(" {0};", array[v]);
                    }
                    Console.WriteLine();
                }
            }
        }
        if (count == 0)
            Console.Write("No finds the given sum in array");
    }
}
