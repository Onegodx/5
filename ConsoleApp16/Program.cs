using System;
using static Program;
//Миньков Владимир вариант 14 

public static class DayOfWeekCalculator
{
    public static int CalculateDayOfWeek(Date date)
    {
        int[] t =
        {
            0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4
        };

        if (date.month < 3)
        {
            date.year--;
        }

        int dayOfWeek = (date.year + date.year / 4 - date.year / 100 + date.year / 400 + t[date.month - 1] + date.day) % 7;

        
        if (dayOfWeek == 0)
        {
            dayOfWeek = 7;
        }

        return dayOfWeek;
    }
}

public class Program
{
    public struct Date
    {
        public int year;
        public int month;
        public int day;
    }

    static void Main()
    {
        Date date = new Date { year = 2023, month = 4, day = 21 };
        int dayOfWeekNumber = DayOfWeekCalculator.CalculateDayOfWeek(date);
        Console.WriteLine($"Day of week: {dayOfWeekNumber}");
    }
}
