/*4.Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is working correctly.*/
using System;

public class CountRepeatingValues
{  
    public static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter number of elements of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Your number {0} exists in the array {1} times.", number, CountRepeatingVal(array, number));
    }
    public static int CountRepeatingVal(int[] array, int number)
    {
        int countRepeatVal = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                countRepeatVal++;
            }
        }
        return countRepeatVal;
    }
}
