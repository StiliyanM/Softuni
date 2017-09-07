using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class StudentInfo
    {
        public List<DateTime> AttendancyDates { get; set; }
        public List<string> Comments { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new SortedDictionary<string, StudentInfo>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of dates")
                {
                    break;
                }

                string date = string.Empty;
                string name = string.Empty;

                var tokens = input.Split(new char[] { ' ', ',' }).ToArray();
                name = tokens[0];

                if (tokens.Length < 2)
                {
                    continue;
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    date = tokens[i];
                    var dateToAdd = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    if (!students.ContainsKey(name))
                        students[name] = new StudentInfo()
                        {
                            AttendancyDates = new List<DateTime>(),
                            Comments = new List<string>()
                        };

                    students[name].AttendancyDates.Add(dateToAdd);
                }

            }
            while (true)
            {
                var input = Console.ReadLine().Split('-').ToArray();

                if (input[0] == "end of comments")
                {
                    break;
                }

                if (!students.ContainsKey(input[0]))
                {
                    continue;
                }

                var name = input[0];
                var comment = string.Empty;

                comment = input[1];
                students[name].Comments.Add(comment);
            }


            foreach (var s in students)
            {
                Console.WriteLine(s.Key);
                StudentInfo studentInfo = s.Value;

                Console.WriteLine("Comments:");

                foreach (var comment in studentInfo.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");

                foreach (var date in studentInfo.AttendancyDates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                    //ToString("dd/MM/yyyy")
                }
            }
        }
    }
}
