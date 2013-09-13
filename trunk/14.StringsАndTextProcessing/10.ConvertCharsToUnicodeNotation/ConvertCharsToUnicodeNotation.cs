/*10.Write a program that converts a string to a sequence of C# 
 * Unicode character literals. Use format strings. Sample input:
 * Sample input:
 *      Hi!
 * Expected output:
 *      \u0048\u0069\u0021
 */
using System;
using System.Text;

class ConvertCharsToUnicodeNotation
{
    static void Main()
    {
        string str = Console.ReadLine();
        StringBuilder sb = new StringBuilder(str.Length * 6);
        foreach (char ch in str)
            sb.AppendFormat("\\u{0:X4}", (int)ch);
        Console.WriteLine(sb);
    }
}