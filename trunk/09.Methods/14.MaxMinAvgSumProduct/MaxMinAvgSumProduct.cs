/*14.Write methods to calculate minimum, maximum, average, sum and product of given
 * set of integer numbers. Use variable number of arguments.*/
using System;

class MaxMinAvgSumProduct
{
    static void Main()
    {
        Console.WriteLine("Min: " + Min(6, 56, 55, 55, 65 ));
        Console.WriteLine("Max: " + Max(11, 5, 103, 2, 89, 653));
        Console.WriteLine("Sum: " + Sum(45, 76, 6, 11, 9));
        Console.WriteLine("Avg: " + Avg(-5, 11, 9, 5));
        Console.WriteLine("Product: " + Product(5, -2, 19, 54, 54));
    }
    static int Min(params int[] array) 
    {
        int min = array[0];
        foreach (int num in array)
        {
            if (num < min) 
                min = num;
        }
        return min;
    }
    static int Max(params int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max) 
                max = num;
        }
        return max;
    }
    static double Avg(params int[] array)
    {
        return ((double)Sum(array) / array.Length);
    }
    static int Sum(params int[] array)
    {
        int sum = 0;
        foreach (int num in array) 
            sum += num;
        return sum;
    }
    static decimal Product(params int[] array)
    {
        decimal product = 1;
        foreach (int num in array)
            product *= (decimal)num;
        return product;
    }

}
