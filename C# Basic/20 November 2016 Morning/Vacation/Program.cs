using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            double studentsTickets = 0;
            double adultsTickets = 0;
            double netFullPrice = 0;

            double nightsPrice = nights * 82.99;

            if(transport == "train")
            {
                studentsTickets = 14.99 * students;
                adultsTickets = 24.99 * adults;
                if(adults + students > 50)
                {
                    studentsTickets /= 2;
                    adultsTickets /= 2;
                }
            }
            else if(transport == "bus")
            {
                studentsTickets = 28.5 * students;
                adultsTickets = 32.5 * adults;
            }
            else if (transport == "boat")
            {
                studentsTickets = 39.99 * students;
                adultsTickets = 42.99 * adults;
            }
            else if (transport == "airplane")
            {
                studentsTickets = 50 * students;
                adultsTickets = 70 * adults;
            }

            double Transport = 2 * (adultsTickets + studentsTickets);
            netFullPrice = (Transport + nightsPrice) * 1.1;
            Console.WriteLine($"{netFullPrice:f2}");
        }
    }
}
