/*25.Write a program that extracts from given HTML file its title (if available), 
 * and its body text without the HTML tags. Example:
 * <html>
 * <head><title>News</title></head>
 * <body><p><a href="http://academy.telerik.com">Telerik
 * Academy</a>aims to provide free real-world practical
 * training for young people who want to turn into
 * skillful .NET software engineers.</p></body>
 * </html>*/
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ExtractAllTextFromHTML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\text.html");
        string text = reader.ReadToEnd();
        Console.WriteLine(text);
        string title = Regex.Match(text, "<title>(.*?)</title>").Groups[1].ToString();
        Console.WriteLine("Title: {0}", title);
        text = Regex.Replace(text, title, "");
        StringBuilder sb = new StringBuilder();
        bool openTag = false;
        bool closeTag = false;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                openTag = true;
            }
            if (closeTag && !openTag)
            {
                sb.Append(text[i]);
            }
            if (text[i] == '<' && closeTag)
            {
                openTag = true;
                closeTag = false;
            }
            if (text[i] == '>' && openTag)
            {
                sb.Append(" ");
                closeTag = true;
                openTag = false;
            }
            if (text[i] == '<' && text[i + 1] == 'b' && i < text.Length - 1)
            {
                sb.Clear();
                sb.Append("Body:");
            }
        }
        
        string newText = sb.ToString();
        string cleanedText = Regex.Replace(newText, @"\s+", " ");
        Console.WriteLine(cleanedText);
        //MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
    }
}
