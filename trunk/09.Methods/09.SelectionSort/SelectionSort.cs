/*9.Write a method that return the maximal element in a portion of array of integers
 * starting at given index. Using it write another method that sorts an array in ascending / descending order.*/
using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] =  ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Maximal element in a portion of array is : ");
        Console.WriteLine(MaximalElement(array,index));
        Console.WriteLine("Array: ");
        PrintArray(array);
        Console.WriteLine("Array Sort Max First: ");
        PrintArray(SortArrayMax(array));
        Console.WriteLine("Array Sort Min First: ");
        PrintArray(SortArrayMin(array));
    }
    static int MaximalElement(int[] array, int index)
    {
        int maxElement = Int32.MinValue;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > maxElement)
                maxElement = array[i];
        }
        return maxElement;
    }
    static int[] SortArrayMax(int[] array)
    {
        int n = array.Length;
        int tmp, max_key;
        for (int j = 0; j < n - 1; j++)
        {
            max_key = j;
            for (int k = j + 1; k < n; k++)
            {
                if (array[k] > array[max_key])
                {
                    max_key = k;
                }
            }
            tmp = array[max_key];
            array[max_key] = array[j];
            array[j] = tmp;
        }
        return array;
    }
    static int[] SortArrayMin(int[] array)
    {
        int n = array.Length;
        int tmp, min_key;
        for (int j = 0; j < n - 1; j++)
        {
            min_key = j;
            for (int k = j + 1; k < n; k++)
            {
                if (array[k] < array[min_key])
                {
                    min_key = k;
                }
            }
            tmp = array[min_key];
            array[min_key] = array[j];
            array[j] = tmp;
        }
        return array;
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, array[i]);
        }
    }
}
