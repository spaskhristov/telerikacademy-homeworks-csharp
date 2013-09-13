/*13.Write a program that reverses the words in given sentence.
 * Example: 
 * "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".*/
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReverseWordsInSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!I know?";
        string regex = @"\s+|,\s*|\.\s*|!\s*|\?\s*";
        List<string> words = new List<string>();
        List<string> puncts = new List<string>();
        foreach (string word in Regex.Split(text, regex))
            words.Add(word);
        foreach (Match separator in Regex.Matches(text, regex))
            puncts.Add(separator.Value);
        for (int i = 0; i < puncts.Count; i++)
            Console.Write(words[words.Count - 2 - i] + puncts[i]);
        Console.WriteLine();
    }
}