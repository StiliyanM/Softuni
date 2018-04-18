namespace _04.WorkForce
{
    using System;

    using _04.WorkForce.Interfaces;

    public class Job : IJob
    {
        private string name;
        private int hoursOfWorkRequired;
        private IEmployee employee;

        public Job(string name, int hoursOfWorkRequired, IEmployee employee)
        {
            this.Name = name;
            this.hoursOfWorkRequired = hoursOfWorkRequired;
            this.employee = employee;
            this.IsFinished = false;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public bool IsFinished { get; private set; }

        public int HoursOfWorkRequired
        {
            get { return this.hoursOfWorkRequired; }
        }

        public void Update(object sender, EventArgs e)
        {
            this.hoursOfWorkRequired -= this.employee.HoursPerWeek;

            if (this.hoursOfWorkRequired <= 0)
            {
                this.IsFinished = true;

                Console.WriteLine($"Job {this.Name} done!");
            }
        }
    }
}