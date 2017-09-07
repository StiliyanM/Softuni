using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Work_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = ReadDateTime();
            DateTime endDate = ReadDateTime();

            DateTime[] nonWorkingDays = AddAllHolidays();

            int workingDaysCounter = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (!IsHoliday(date))
                    workingDaysCounter++;
                
            }

            Console.WriteLine(workingDaysCounter);
        }

        private static bool IsHoliday(DateTime date)
        {
            bool isHoliday = false;

            if (date.DayOfWeek.ToString() == "Saturday" || date.DayOfWeek.ToString() == "Sunday")
            {
                isHoliday = true;
                return isHoliday;
            }


            DateTime[] holidays = AddAllHolidays();

            foreach (var h in holidays)
            {
                bool monthEqual = false;
                bool dayEqual = false;

                if (h.Month == date.Month)
                    monthEqual = true;
                if (h.Day == date.Day)
                    dayEqual = true;

                isHoliday = monthEqual && dayEqual;

                if (isHoliday == true)
                    break;
            }

            return isHoliday;
        }

        private static DateTime[] AddAllHolidays()
        {
            DateTime[] holidays = new DateTime[11];

            holidays[0] = new DateTime(2000, 1, 1);
            holidays[1] = new DateTime(2000, 3, 3);
            holidays[2] = new DateTime(2000, 5, 1);
            holidays[3] = new DateTime(2000, 5, 6);
            holidays[4] = new DateTime(2000, 5, 24);
            holidays[5] = new DateTime(2000, 9, 6);
            holidays[6] = new DateTime(2000, 9, 22);
            holidays[7] = new DateTime(2000, 11, 1);
            holidays[8] = new DateTime(2000, 12, 24);
            holidays[9] = new DateTime(2000, 12, 25);
            holidays[10] = new DateTime(2000, 12, 26);

            return holidays;
        }

        private static DateTime ReadDateTime()
        {
            var inputLine = Console.ReadLine();
            DateTime date = DateTime.ParseExact(inputLine, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            return date;
            
        }
    }
}
