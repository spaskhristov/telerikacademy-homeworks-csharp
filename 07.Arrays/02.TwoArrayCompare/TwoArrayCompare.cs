/*2.Write a program that reads two arrays from the console and 
 * compares them element by element.*/
using System;

class TwoArrayCompare
{
    static void Main(string[] args)
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] array2 = new int[n];
        bool areEqual = true;
        for (int i = 0; i < n; i++)
        {
            Console.Write("array1 [{0}] =  ", i);
            array1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("array2 [{0}] =  ", i);
            array2[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array1);
        Array.Sort(array2);
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                areEqual = false;
                break;
            }
        }
        Console.WriteLine("The two arrays are equal: {0}", areEqual);
    } 
}
