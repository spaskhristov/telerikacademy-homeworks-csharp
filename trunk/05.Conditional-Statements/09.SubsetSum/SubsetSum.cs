//9.We are given 5 integer numbers. Write a program that checks if the sum of 
//some subset of them is 0.
//Example: 3, -2, 1, 1, 8 -> 1+1-2=0.
using System;

class SubsetSum
{
    static void Main()
    {
        int sum = 0;
        int number = 5;
        int[] elements = new int[number];
        string subset = "";
        for (int i = 0; i < elements.Length; i++)
        {
            Console.Write("X{0} = ", i + 1);
            elements[i] = int.Parse(Console.ReadLine());
        }
        int maxSubsets = (int)Math.Pow(2, number);
        for (int i = 1; i < maxSubsets; i++)
        {
            subset = "";
            int checkingSum = 0;
            for (int j = 0; j <= number; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + elements[j];
                    subset = subset + " " + elements[j];
                }
            }
            if (checkingSum == sum)
            {
                Console.WriteLine("{1} = {0} ", sum, subset);
            }
        }
    }
}