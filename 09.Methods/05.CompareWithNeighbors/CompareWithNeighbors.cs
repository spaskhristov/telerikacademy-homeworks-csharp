/*5.Write a method that checks if the element at given position in given array of integers is
 * bigger than its two neighbors (when such exist).*/
using System;

public class CompareWithNeighbors
{
    public static bool IsInside(int[] array, int position)
    {
        if (0 <= position && position < array.Length)
            return true;
        else
            return false;
    }
    public static bool IsBigger(int[] array, int position, int positionNeighbours)
    {
        if (IsInside(array, positionNeighbours))
        {
            if (array[position] > array[positionNeighbours])
                return true;
            else
                return false;
        }
        else
            return false;
    }
    public static bool IsBiggerThanNeighbours(int[] array, int position)
    {
        if (IsBigger(array, position, position - 1) && IsBigger(array, position, position + 1))
            return true;
        else
            return false;
    }
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
        for (int position = 0; position < array.Length; position++)
        {
            Console.WriteLine("Element {0} at position {1} is bigger than its two neighbors {2}", array[position], position, IsBiggerThanNeighbours(array, position));
        }
    }
}
