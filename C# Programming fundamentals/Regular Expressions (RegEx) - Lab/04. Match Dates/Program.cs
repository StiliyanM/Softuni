﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var datesInput = Console.ReadLine();

            var dates = Regex.Matches(datesInput, regex);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        } 
    }
}
