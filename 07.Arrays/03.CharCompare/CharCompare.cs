/*3.Write a program that compares two char arrays 
 * lexicographically (letter by letter).*/
using System;

class CharCompare
{
    static void Main()
    {
        Console.Write("Enter the first array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the second array length: ");
        int m = int.Parse(Console.ReadLine());
        char[] array1 = new char[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array [{0}] =  ", i);
            array1[i] = char.Parse(Console.ReadLine());
        }
        char[] array2 = new char[m];
        for (int i = 0; i < m; i++)
        {
            Console.Write("array [{0}] =  ", i);
            array2[i] = char.Parse(Console.ReadLine());
        }
        bool areLexiEqual = true;
        if (array1.Length == array2.Length)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    areLexiEqual = false;
                }
            }
            Console.WriteLine("The two arrays lexicographically are equal: {0}", areLexiEqual);
        }
        else
        {
            areLexiEqual = false;
            Console.WriteLine("The two arrays lexicographically are equal: {0}", areLexiEqual);
        }
    }
}
