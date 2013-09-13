/*18.Write a program for extracting all email addresses from given text. All substrings
 * that match the format <identifier>@<host>…<domain> should be recognized as emails.*/
using System;
using System.Text.RegularExpressions;

class ExtractAllEmails
{
    static void Main()
    {
        string text = "bg544@google.com.ul example@abv.bg. or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        //@"[\w._]+@[\w-.]+\.[\w]{2,3}"
        //@"\w+@\w+\.\w+"
        foreach (var item in Regex.Matches(text, @"\w+@[\w-.]+\.[A-Za-z0-9_]{2,6}"))
            Console.WriteLine(item);
    }
}