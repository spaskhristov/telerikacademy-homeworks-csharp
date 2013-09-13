/*8.Write a method that adds two positive integer numbers represented as arrays of digits
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.*/
using System;
using System.Collections.Generic;

public class SumNumbersRepresentedAsArrays
{
    public static void Main()
    {
        int[] first = { 1, 2, 5, 6, 9, 1, 7, 6 };
        int[] second = { 9, 9, 6, 9, 1, 6, 9, 6, 9, 8, 2, 6, 9, 9, 6, 9, 1, 6, 9, 6, 9, 8, 2, 6, 9, 9, 6, 9, 1, 6, 9, 6, 9, 8, 2, 6, 9, 9, 6, 9, 1, 6, 9, 6, 9, 8, 2, 6 };
        int[] result = Add(first, second);
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
    public static int[] Add(int[] first, int[] second)
    {
        Array.Reverse(first);
        Array.Reverse(second);
        int n = (Math.Max(first.Length,second.Length)+1);
        int[] result = new int[n];  
        bool oneInMind = false;
        for (int i = 0; i < n; i++)
        {
            int digit = 0;
            if (i < first.Length && i < second.Length)
            {
                if (oneInMind == true)
                    digit = first[i] + second[i] + 1;
                if (oneInMind == false)
                {
                    digit = first[i] + second[i];
                }
                if (digit > 9)
                {
                    oneInMind = true;
                    result[i] = digit % 10;
                }
                if (digit <= 9)
                {
                    oneInMind = false;
                    result[i] = digit;
                }
            }
            if (i < first.Length && i >= second.Length)
            {
                if (oneInMind == true)
                    digit = first[i] + 1;
                if (oneInMind == false)
                {
                    digit = first[i];
                }
                if (digit > 9)
                {
                    oneInMind = true;
                    result[i] = digit % 10;
                }
                if (digit <= 9)
                {
                    oneInMind = false;
                    result[i] = digit;
                }
            }
            if (i >= first.Length && i < second.Length)
            {
                if (oneInMind == true)
                    digit = second[i] + 1;
                if (oneInMind == false)
                {
                    digit = second[i];
                }
                if (digit > 9)
                {
                    oneInMind = true;
                    result[i] = digit % 10;
                }
                if (digit <= 9)
                {
                    oneInMind = false;
                    result[i] = digit;
                }
            }
            if (i >= first.Length && i >= second.Length)
            {
                if (oneInMind == true)
                    digit = 1;
                if (oneInMind == false)
                {
                    digit = 0;
                }
                if (digit > 9)
                {
                    oneInMind = true;
                    result[i] = 0;
                }
                if (digit <= 9)
                {
                    oneInMind = false;
                    result[i] = digit;
                }
            }
        }
        if (result[result.Length - 1] == 0)
        {
            Array.Resize(ref result, result.Length - 1);
        }
        return result;
    }
}
