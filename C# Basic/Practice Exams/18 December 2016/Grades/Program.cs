using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());

            double allGrades = 0;
            double failCnt = 0;
            double between3and4Cnt = 0;
            double between4and5Cnt = 0;
            double topStudentsCnt = 0;


            for (int i = 0; i < students; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                if (grade < 3)
                {
                    failCnt++;
                    allGrades += grade;
                }
                else if (grade < 4)
                {
                    between3and4Cnt++;
                    allGrades += grade;

                }
                else if(grade < 5)
                {
                    allGrades += grade;
                    between4and5Cnt++;
                }
                else
                {
                    allGrades += grade;
                    topStudentsCnt++;
                }
            }

            double average = (double)allGrades / students;

            Console.WriteLine($"Top students: { topStudentsCnt / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4and5Cnt / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3and4Cnt / students * 100:f2}%");
            Console.WriteLine($"Fail: {failCnt / students * 100:f2}%");
            Console.WriteLine($"Average: {allGrades / students:f2}");

        }
    }
}
