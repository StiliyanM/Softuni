using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {

        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade
            {
                get
                {
                    return Grades.Average();
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                students.Add(ReadStudent());
            }

            var filteredStudents = students.Where(x => x.AverageGrade >= 5.00).ToList();

            foreach (var student in filteredStudents.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }

        private static Student ReadStudent()
        {
            var student = new Student();

            var inputLine = Console.ReadLine().Split().ToArray();
            student.Name = inputLine[0];
            var gradesList = new List<double>();
            for (int i = 1; i < inputLine.Length; i++)
            {
                gradesList.Add(double.Parse(inputLine[i]));
            }

            student.Grades = gradesList;
            return student;
        }
    }
}
