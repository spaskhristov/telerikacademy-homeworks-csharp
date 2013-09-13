/*7.Write a program that reads two integer numbers N 
 * and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.*/
using System;

class SelectSort
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
		int n = int.Parse(Console.ReadLine());
		int[] array = new int[n];
		for (int i = 0; i < n; i++)
		{
			Console.Write("array[{0}] =  ", i);
			array[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Array: ");
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine("array[" + i +"] = " +array[i]);
        }
 		// Now we will use selection sort
       	int tmp, min_key;
        for (int j = 0; j < array.Length - 1; j++)
		{
            min_key = j;
            for (int k = j + 1; k < array.Length; k++)
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
		Console.WriteLine("Array Sort: ");
        for (int i = 0; i < array.Length; i++)
		{
            Console.WriteLine("array[{0}] = {1}", i, array[i] );
        }
    }
}
