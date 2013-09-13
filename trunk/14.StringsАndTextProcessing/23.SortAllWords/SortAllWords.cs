//24.Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;

class SortAllWords
{
    static void Main()
    {
        string[] allWords = Console.ReadLine().Split();
        Array.Sort(allWords);
        for (int i = 0; i < allWords.Length; i++)
        {
            Console.WriteLine(allWords[i]);
        }
    }
}

