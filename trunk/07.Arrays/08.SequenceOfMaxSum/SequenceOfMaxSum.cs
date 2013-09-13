/*8.Write a program that finds the sequence of maximal 
 * sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan 
 * through the elements of the array)?*/
using System;
using System.Text;

class SequenceOfMaxSum
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array [{0}] =  ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int currentSum = 0;
        int bestSum = int.MinValue;
        StringBuilder sb = new StringBuilder();
        string bestSequnce = "";
        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            sb.AppendFormat("{0};", array[i]);
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestSequnce = sb.ToString();
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                sb.Clear();
            }
        }
        Console.WriteLine("The best sequence is: \"{0}\"", bestSequnce);
        Console.WriteLine("The best sum is: {0} ", bestSum);
    }
}
