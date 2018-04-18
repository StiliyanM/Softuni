namespace _04.WorkForce.Employees
{
    using _04.WorkForce.Interfaces;

    public class PartTimeEmployee : IEmployee
    {
        private const int DEFAULT_HOURS_PER_WEEK = 20;

        private string name;
        private int hoursPerWeek;

        public PartTimeEmployee(string name)
        {
            this.Name = name;
            this.hoursPerWeek = DEFAULT_HOURS_PER_WEEK;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int HoursPerWeek
        {
            get { return this.hoursPerWeek; }
        }
    }
}