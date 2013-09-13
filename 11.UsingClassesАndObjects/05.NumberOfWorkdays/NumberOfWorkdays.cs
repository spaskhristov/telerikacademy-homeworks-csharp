/* 5.Write a method that calculates the number of workdays between
 * today and given date, passed as parameter. Consider that workdays
 * are all days from Monday to Friday except a fixed
 * list of public holidays specified preliminary as array.
 */
using System;

public class NumberOfWorkdays
{
    public static void Main()
    {
        Console.Write("Enter a end date in YYYY.MM.DD format ");
        string[] endDateStr = Console.ReadLine().Split('.');
        int year = int.Parse(endDateStr[0]);
        int month = int.Parse(endDateStr[1]);
        int day = int.Parse(endDateStr[2]);
        DateTime startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int timeLen = 0;
        timeLen = Math.Abs((endDay - startDay).Days);
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }
        DateTime[] holidays =
        {
            new DateTime(2014, 1, 1),
            new DateTime(2013, 1, 1),
            new DateTime(2013, 3, 3),
            new DateTime(2013, 5, 1),
            new DateTime(2013, 5, 2),
            new DateTime(2013, 5, 3),
            new DateTime(2013, 5, 4),
            new DateTime(2013, 5, 5),
            new DateTime(2013, 5, 6),
            new DateTime(2013, 5, 24),
            new DateTime(2013, 9, 6),
            new DateTime(2013, 9, 22),
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),
            new DateTime(2013, 12, 31)
        };
        int workDayCounter = 0;
        bool isHoliday = false;
        for (int i = 0; i < timeLen; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDayCounter++;
                }

                isHoliday = false;
            }
        }
        Console.WriteLine("Workdays between {0} and {1} are {2}", DateTime.Now.ToString("yyyy.MM.dd"), endDay.ToString("yyyy.MM.dd"), workDayCounter);
    }
}
