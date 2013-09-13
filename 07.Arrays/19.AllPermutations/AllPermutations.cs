/*19.* Write a program that reads a number N and generates and prints
 * all the permutations of the numbers [1 … N]. Example:
 * n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}*/
using System;

class AllPermutations
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            myArray[i] = i + 1;
        }
        Permute(myArray, 0, myArray.Length - 1);
    }
    static void Permute(int[] array, int current, int length)
    {
        if (current == length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Swap(ref array[i], ref array[current]);
                Permute(array, current + 1, length);
                Swap(ref array[i], ref array[current]);
            }
        }
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }
}