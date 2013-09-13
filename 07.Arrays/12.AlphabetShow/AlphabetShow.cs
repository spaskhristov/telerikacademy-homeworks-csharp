/*12.Write a program that creates an array containing all letters 
 * from the alphabet (A-Z). Read a word from the console and print
 * the index of each of its letters in the array.*/
using System;

class AlphabetShow
{
    static void Main()
    {
        Console.Write("Enter the word: ");
        string str = Console.ReadLine();
        string strUpp = str.ToUpper();
        char[] charArray = strUpp.ToCharArray();
        int index;
        Console.WriteLine("Indexes letters the word: ");
        foreach (char ch in charArray)
        {
            index = (int)ch - (int)'A' + 1;
            Console.WriteLine(ch + " = " + index);
        }
    }
}