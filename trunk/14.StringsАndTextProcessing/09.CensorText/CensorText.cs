using System;
using System.Text.RegularExpressions;

class CensorText
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language";
        string[] forbidenWords = "PHP, CLR, Microsoft".Split(',');
        for (int i = 0; i < forbidenWords.Length; i++)
        {
            forbidenWords[i] = forbidenWords[i].Trim();
            text = text.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
        }
        Console.WriteLine(text);
    }
}