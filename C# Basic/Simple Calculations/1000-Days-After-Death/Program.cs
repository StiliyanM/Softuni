using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

    public class Program
    {
        public static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(birthDate, "dd-MM-yyyy",CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy",CultureInfo.InvariantCulture));
        }
    }
