using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main(string[] args)
    {
        try
        {

            var studentArgs = Console.ReadLine().Split();

            var facultyNumber = studentArgs[2];

            var student = new Student(studentArgs[0],studentArgs[1], facultyNumber);

            var workerArgs = Console.ReadLine().Split();

            var firstName = workerArgs[0];
            var lastName = workerArgs[1];
            var salary = decimal.Parse(workerArgs[2]);
            var workingHours = decimal.Parse(workerArgs[3]);

            var worker = new Worker(firstName, lastName, salary, workingHours);

            Console.WriteLine(student + Environment.NewLine);
            Console.WriteLine(worker);
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}

