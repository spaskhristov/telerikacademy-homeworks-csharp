/*6.Write a method that returns the index of the first element in array that is bigger than its neighbors,
 * or -1, if there’s no such element.
 * Use the method from the previous exercise.*/
using System;

public class GetFirstElementBiggerThanNeighbors
{
    public static void Main()
    {
        Console.Write("Enter number of elements of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Index of the first element in array that is bigger than its neighbors is {0}", GetElementBiggerThanNeighbours(array));
    }
    public static int GetElementBiggerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (CompareWithNeighbors.IsBiggerThanNeighbours(array, i))
                return i;
        }
        return -1;
    }
}

