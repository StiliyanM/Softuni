using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        var departments = new Dictionary<string, List<Employee>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split();

            var name = args[0];
            var salary = decimal.Parse(args[1]);
            var position = args[2];
            var department = args[3];
            int age;
            string email = "";

            var employee = new Employee();
            if (args.Length == 4)
            {
                employee = new Employee(name, salary, position, department);
            }
            else if (args.Length == 5)
            {
                if (isInt(args[4]))
                {
                    age = int.Parse(args[4]);
                    employee = new Employee(name, salary, position, department, age);
                }
                else
                {
                    email = args[4];
                    employee = new Employee(name, salary, position, department, email);
                }
            }
            else if (args.Length == 6)
            {
                if (isInt(args[4]))
                {
                    age = int.Parse(args[4]);
                    email = args[5];
                }
                else
                {
                    age = int.Parse(args[5]);
                    email = args[4];
                }
                employee = new Employee(name, salary, position, department, email, age);
            }

            if (!departments.ContainsKey(department))
            {
                departments[department] = new List<Employee>();
            }
            departments[department].Add(employee);
        }

        decimal highestAvgSalary = 0;
        var deptWithHighestSalary = "";
        foreach (var d in departments)
        {
            decimal totalSalary = 0;
            decimal averageSalary = 0;
            foreach (var e in d.Value)
            {
                totalSalary += e.Salary;
            }
            averageSalary = totalSalary / d.Value.Count();

            if (averageSalary > highestAvgSalary)
            {
                highestAvgSalary = averageSalary;
                deptWithHighestSalary = d.Key;
            }
        }

        Console.WriteLine($"Highest Average Salary: {deptWithHighestSalary}");

        foreach (var e in departments[deptWithHighestSalary]
            .OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{e.Name} {e.Salary:f2} {e.Email} {e.Age}");
        }
    }

    private static bool isInt(string v)
    {
        var isInt = true;
        foreach (var ch in v)
        {
            if (!char.IsDigit(ch))
            {
                isInt = false;
                break;
            }
        }

        return isInt;
    }
}

