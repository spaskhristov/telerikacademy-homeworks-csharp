/*18.* Write a program that reads an array of integers and removes from it a minimal 
 * number of elements in such way that the remaining array is sorted in increasing order.
 * Print the remaining sorted array. Example:
 * {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}*/
using System;

class SortedInIncreasingOrder
{
    static void Main(string[] args)
    {
        int i, n, mask;
        int count = 0;
        Console.Write("n:");
        n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        int[] maskArray = new int[n];
        for (i = 0; i < myArray.Length; i++)
        {
            Console.Write("a[{0}]:", i + 1);
            myArray[i] = int.Parse(Console.ReadLine());
        }
        if (myArray[0] <= myArray[1])
        {
            maskArray[0] = myArray[0];
            mask = maskArray[count];
            count++;
        }
        else
        {
            myArray[0] = myArray[1];
            mask = 0;
        } 
        for (i = 1; i < n-1; i++)
        {
            if ((myArray[i] < myArray[i - 1] && myArray[i - 1] <=mask) ||
                (myArray[i] > myArray[i + 1]&&myArray[i+1]>=mask))
            {
                myArray[i] = myArray[i-1];
            }
            else
            {
                maskArray[count] = myArray[i];
                mask = maskArray[count];
                count++;
            }
        }
        if (myArray[n - 1] >= myArray[n - 2])
        {
            maskArray[count] = myArray[n-1];
            count++;
        }
        for (i = 0; i < count; i++)
        {
            Console.WriteLine(maskArray[i]+" ");
        }
    }
}