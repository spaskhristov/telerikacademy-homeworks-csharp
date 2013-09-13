/*4.Write a program, that reads from the console an array of N integers and an integer K,
 * sorts the array and using the method Array.BinSearch()
 * finds the largest number in the array which is ≤ K.*/
using System;
using System.Collections;

class SearchForElem
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArray);
        int elemIndex = Array.BinarySearch(myArray, k);
        while (true)
        {
            if (elemIndex < 0)
            {
                --k;
                elemIndex = Array.BinarySearch(myArray, k);
            }
            else if (elemIndex <= k)
            {
                Console.WriteLine("Element <= K found at index [{0}] = {1}", elemIndex, myArray[elemIndex]); break;
            }
            else
            {
                Console.WriteLine("Element not found!"); break;
            }
        }
    }
}