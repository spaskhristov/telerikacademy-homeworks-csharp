/*21.Write a program that reads two numbers N and K and generates all 
 * the combinations of K distinct elements from the set [1..N]. Example:
 * N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}*/
using System;

class AllCombinations
{
    static int[] myArray;
    static int k;
    static int n;
    static void Main()
    {
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        k = int.Parse(Console.ReadLine());
        myArray = new int[k];
        Combinatate(0, 1);
    }
    static void Combinatate(int index, int startValue)
    {
        if (index == k)
        {
            for (int i = 0; i < k; i++)
                Console.Write("{0,3}", myArray[i]);
            Console.WriteLine();
            return;
        }
        for (int i = startValue; i <= n; i++)
        {
            myArray[index] = i;
            Combinatate(index + 1, i + 1);
        }
    }
}