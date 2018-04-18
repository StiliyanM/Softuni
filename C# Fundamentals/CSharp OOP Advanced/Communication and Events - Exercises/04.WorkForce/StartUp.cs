namespace _04.WorkForce
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _04.WorkForce.Employees;
    using _04.WorkForce.Interfaces;

    class StartUp
    {
        static void Main()
        {
            var jobs = new List<IJob>();
            var employees = new List<IEmployee>();
            var manager = new WorkForceManager();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(' ');

                string command = data[0];
                data = data.Skip(1).ToArray();

                switch (command)
                {
                    case "Job": AddJob(jobs, employees, data, manager); break;
                    case "StandardEmployee": AddStandartEmployee(employees, data); break;
                    case "PartTimeEmployee": AddPartTimeEmployee(employees, data); break;
                    case "Pass":
                        manager.PassWeek();

                        ClearFinishedJobs(jobs, manager);

                        break;
                    case "Status":
                        foreach (var job in jobs)
                        {
                            Console.WriteLine($"Job: {job.Name} Hours Remaining: {job.HoursOfWorkRequired}");
                        }

                        break;
                }
            }
        }

        private static void ClearFinishedJobs(List<IJob> jobs, WorkForceManager manager)
        {
            foreach (var job in jobs.Where(x => x.IsFinished))
            {
                manager.WorkHandler -= job.Update;
            }

            jobs.RemoveAll(x => x.IsFinished);
        }

        private static void AddPartTimeEmployee(List<IEmployee> employees, string[] data)
        {
            string partTimeEmployeeName = data[0];

            employees.Add(new PartTimeEmployee(partTimeEmployeeName));
        }

        private static void AddStandartEmployee(List<IEmployee> employees, string[] data)
        {
            string standartEmployeeName = data[0];

            employees.Add(new StandartEmployee(standartEmployeeName));
        }

        private static void AddJob
            (List<IJob> jobs, List<IEmployee> employees, string[] data, WorkForceManager manager)
        {
            string jobName = data[0];
            int hoursOfWorkRequired = int.Parse(data[1]);
            string employeeName = data[2];

            IEmployee employee = employees.FirstOrDefault(x => x.Name == employeeName);

            var job = new Job(jobName, hoursOfWorkRequired, employee);

            manager.WorkHandler += job.Update;

            jobs.Add(job);
        }
    }
}
