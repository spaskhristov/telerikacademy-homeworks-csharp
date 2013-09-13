/*5.You are given an array of strings. Write a method that sorts the array by the 
 * length of its elements (the number of characters composing them).*/
using System;
using System.Linq;

class StringLenSort
{
    static void Main()
    {
        Console.Write("Enter string array lenght: ");
        int n = int.Parse(Console.ReadLine());
        string[] str = new string[n];
        for (int i = 0; i < n; i++)
        {
            str[i] = Console.ReadLine();
        }
        foreach (var item in str.OrderBy(x => x.Length))
        {
            Console.WriteLine(item);
        }
    }
}