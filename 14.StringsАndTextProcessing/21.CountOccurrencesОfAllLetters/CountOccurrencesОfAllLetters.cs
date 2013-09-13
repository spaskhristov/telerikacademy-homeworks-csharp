/*21.Write a program that reads a string from the console and prints all different letters in 
 * the string along with information how many times each letter is found.*/
using System;
using System.Collections.Generic;
using System.Linq;

public class CountOccurrencesОfAllLetters
{
    public static void Main()
    {
        string str = Console.ReadLine();
        str = str.ToLower();
        Dictionary<char, int> allLetters = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (Char.IsLetter(ch))
            {
                if (allLetters.ContainsKey(ch))
                {
                    allLetters[ch]++;
                }
                else
                {
                    allLetters.Add(ch, 1);
                }
            }
        }
        var sortedLetters = allLetters.OrderBy(x => x.Key);
        foreach (var letter in sortedLetters)
        {
            Console.WriteLine("Letter \"{0}\" is repeated {1} times",
            letter.Key,
            letter.Value);
        }
    }
}