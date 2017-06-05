using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var employees = int.Parse(Console.ReadLine());

            double workableHours = (days - days * 0.1) * 8;
            double extraHours = employees * (days * 2);
            double totalHours = Math.Floor(workableHours + extraHours);

            if(totalHours > hoursNeeded)
                Console.WriteLine("Yes!{0} hours left.", totalHours - hoursNeeded);
            else if(totalHours < hoursNeeded)
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeeded - totalHours);

        }
    }
}
