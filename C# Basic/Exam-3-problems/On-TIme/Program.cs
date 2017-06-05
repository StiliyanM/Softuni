using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_TIme
{
    class Program
    {
        static void Main(string[] args)
        {
            var ExamHour = int.Parse(Console.ReadLine());
            var ExamMinute = int.Parse(Console.ReadLine());
            var Studenthour = int.Parse(Console.ReadLine());
            var Studentminute = int.Parse(Console.ReadLine());

            int hour = Math.Abs(ExamHour - Studenthour);
            int minute = Math.Abs(ExamMinute - Studentminute);

            if (Studenthour > ExamHour || Studenthour == ExamHour && Studentminute > ExamMinute)
            {
                Console.WriteLine("Late");
                if (hour == 0 && minute > 10)
                    Console.WriteLine("{0} minutes after the start", minute);
                else if (hour == 0 && minute < 10)
                    Console.WriteLine("0{0} minutes after the start", minute);
                else if (hour > 0 && minute > 10)
                    Console.WriteLine("{0}:{1} hours after the start", hour, minute);
                else if(hour > 0 && minute < 10)
                    Console.WriteLine("{0}:0{1} hours after the start", hour, minute);
            }
            else if(hour == 0 && Studentminute < ExamMinute && minute <= 30)
            {
                Console.WriteLine("On time");
                if(minute > 10)
                    Console.WriteLine("{0} minutes before the start", minute);
                else if(minute < 10 && minute > 0)
                    Console.WriteLine("0{0} minutes before the start", minute);
            }
            else if(Studenthour < ExamHour || Studenthour == ExamHour && Studentminute < ExamMinute && minute > 30)
            {
                Console.WriteLine("Early");
                if(hour == 0)
                    Console.WriteLine("{0} minutes before the start", minute);
                else if(hour > 0 && minute > 10)
                    Console.WriteLine("{0}:{1} hours before the start", hour, minute);
                else if(hour > 0 && minute < 10)
                    Console.WriteLine("{0}:0{1} hours before the start", hour, minute);
            }
        }
    }
}
