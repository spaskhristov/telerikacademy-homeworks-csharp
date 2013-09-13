/*19.Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
 * Display them in the standard date format for Canada.*/﻿
using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractAllDates
{
    static void Main()
    {
        string text = @"I was born at -14.06.1980.You was born at 14.6.1955. Tom was born at 4.06.1955.
        My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) 
        that we are allowed to do this (section 7.4.2.9).2";
        DateTime date;
        foreach (Match item in Regex.Matches(text, @"\b\d{1,2}.\d{1,2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date)
                || DateTime.TryParseExact(item.Value, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
        }
    }
}