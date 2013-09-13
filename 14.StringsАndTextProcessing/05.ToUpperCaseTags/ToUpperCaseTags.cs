/*5.You are given a text. Write a program that changes the text in all regions 
 * surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
 * Example:
 * We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
 * The expected result:
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/
using System;

class ToUpperCaseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string startTags = "<upcase>";
        string endTags = "</upcase>";
        while (text.IndexOf(startTags) != -1)
        {
            int startPos = text.IndexOf(startTags);
            int endPos = text.IndexOf(endTags);
            string temp = text.Substring(startPos + startTags.Length, endPos - startPos - startTags.Length);
            text = text.Replace(startTags + temp + endTags, temp.ToUpper());
        }
        Console.WriteLine(text);
    }
}
