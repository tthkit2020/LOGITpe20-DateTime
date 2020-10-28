using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");
            int yearToday = today.Year;
            Console.WriteLine($"Current year from today {yearToday}");
            var weekDayToday = today.DayOfWeek;
            Console.WriteLine($"It's {weekDayToday}!");
            Console.WriteLine("----------------");

            DateTime todayDetails = DateTime.Now;
            Console.WriteLine($"Today in details: {todayDetails}");
            DateTime utc = DateTime.UtcNow;
            Console.WriteLine($"UTC Time {utc}");

            //DateTime(year, month, day, hour, minute)
            DateTime christmasEve = new DateTime(2020, 12, 24);
            var christmasDayOfWeek = christmasEve.DayOfWeek;
            Console.WriteLine($"This year Christmas Eve is on {christmasDayOfWeek}");


        }
    }
}
