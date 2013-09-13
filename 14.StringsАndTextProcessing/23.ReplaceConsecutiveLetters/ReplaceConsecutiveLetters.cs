/*23.Write a program that reads a string from the console and replaces all series of consecutive
 * identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".*/
using System;
using System.Text.RegularExpressions;

class ReplaceConsecutiveLetters
{
    static void Main()
    {
        string str = "aaaaabbbbbcdddeee221edssaa sdsass asasaaaaas 12322 ddsds ^$%%^";
        Console.WriteLine(str);
        Console.WriteLine(Regex.Replace(str, @"([A-Za-z])\1+", "$1"));
    }
}
