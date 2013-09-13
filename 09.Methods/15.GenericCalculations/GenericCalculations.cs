/*15.* Modify your last program and try to make it work for any number type, not
 * just integer (e.g. decimal, float, byte, etc.). Use generic method (read in 
 * Internet about generic methods in C#).*/
using System;
using System.Collections.Generic;

class GenericCalculations
{
    static void Main()
    {
        Console.WriteLine("Min: " + Min(6.5, 56.56, 4, 55, 65));
        Console.WriteLine("Max: " + Max(11, 5, 103, 2.56, 89, 653));
        Console.WriteLine("Sum: " + Sum(45, 76, 6, 11, 9.6));
        Console.WriteLine("Avg: " + Avg(69, -3, 'A', 12.6)); //'A' = 65
        Console.WriteLine("Product: " + Product(5, -2.65, 19, 54, 54));
    }
    static dynamic Min(params dynamic[] array) 
    {
        dynamic min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    static dynamic Max(params dynamic[] array)
    {
        dynamic max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    static dynamic Sum(params dynamic[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum;
    }
    static dynamic Avg(params dynamic[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return (sum / array.Length);
    }
    static dynamic Product(params dynamic[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product = product * array[i];
        }
        return product;
    }
}
