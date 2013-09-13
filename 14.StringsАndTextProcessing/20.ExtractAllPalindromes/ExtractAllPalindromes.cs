//20.Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractAllPalindromes
{
    static void Main()
    {
        string text = @"Nice blue sky. No exe flying in the sky. ABBA will not come in Bulgaria.
       I don`t know what is lamal, maybe I will find some day. mouseesuom. Bombard a drab mob.";
        List<string> words = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (Char.IsLetter(ch))
                sb.Append(ch);
            if ((Char.IsSeparator(ch) || i == text.Length - 1) && (sb.ToString().Length > 1))
            {
                words.Add(sb.ToString());
                sb.Clear();
            }

        }
        for (int i = 0; i < words.Count; i++)
        {
            if (IsPalindrome(words[i]))
                Console.WriteLine(words[i]);
        }
        //foreach (Match item in Regex.Matches(text, @"\w+"))
           // if (IsPalindrome(item.Value)) Console.WriteLine(item);
        //foreach (Match item in Regex.Matches(text, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b"))
            //Console.WriteLine(item);
    }
    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
            if (word[i] != word[word.Length - 1 - i])
                return false;
        return true;
    }
}