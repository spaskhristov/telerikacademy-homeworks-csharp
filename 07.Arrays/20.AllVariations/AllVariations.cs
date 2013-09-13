/*20.Write a program that reads two numbers N and K and generates
 * all the variations of K elements from the set [1..N]. Example:
 * N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}*/
using System;

class AllVariations
{
    static int n;
    static int k;
    static void Main()
    {
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        k = int.Parse(Console.ReadLine());
        int[] myArray = new int[k];
        Variations(myArray, 0);
    }
    static void Variations(int[] array, int index)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                Variations(array, index + 1);
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
}