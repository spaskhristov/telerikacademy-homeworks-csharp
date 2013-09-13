/*22.Write a program that reads a string from the console and lists all different
 * words in the string along with information how many times each word is found.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CountOccurrencesOfAllWords
{
    public static void Main()
    {
        string str = Console.ReadLine();
        str = str.ToLower();
        Dictionary<string, int> allWords = new Dictionary<string, int>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (Char.IsLetter(ch))
                sb.Append(ch);
            if ((Char.IsSeparator(ch) || i == str.Length - 1) && (sb.ToString().Length > 1))
            {
                string word = sb.ToString();
                if (allWords.ContainsKey(word))
                {
                    allWords[word]++;
                }
                else
                {
                    allWords.Add(word, 1);
                }
                sb.Clear();
            }
        }
        var sortedWords = allWords.OrderBy(x => x.Key);
        foreach (var word in sortedWords)
        {
            Console.WriteLine("Word \"{0}\" is repeated {1} times",
            word.Key,
            word.Value);
        }
    }
}