﻿/*17.Write a program that reads a date and time given in the format: day.month.year hour:minute:second
 * and prints the date and time after 6 hours and 30 minutes (in the same format)
 * along with the day of week in Bulgarian.*/
using System;
using System.Globalization;

class FormatDateInGivenCulture
{
    static void Main()
    {
        string strDate = "25.08.2013 23:00:00";
        DateTime date = DateTime.ParseExact(strDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}