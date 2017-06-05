using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            //  IFormatProvider provider = IFormatProvider.Equals()
            DateTime date = DateTime.ParseExact(birthDate, "dd-MM-yyyy",CultureInfo.CurrentCulture);
            date.AddDays(999);
            date.ToString("dd-MM-yyyy");
            Console.WriteLine(date);

            
        }
    }
}
