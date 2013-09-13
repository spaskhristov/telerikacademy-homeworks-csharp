/*16.Write a program that reads two dates in the format: day.month.year and calculates
 * the number of days between them. 
 * Example:
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2004
 * Distance: 4 days*/
using System;
using System.Globalization;

class CalculateNumberOfDaysBetweenTwoDates
{
    static void Main()
    {
        Console.Write("Enter the first date (d.mm.yyyy) ");
        string start = Console.ReadLine();
        Console.Write("Enter the second date (d.mm.yyyy): ");
        string end = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Distance: {0}", (endDate - startDate).TotalDays);
    }
}