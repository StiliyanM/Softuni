namespace Employees.App.Commands
{
    using Employees.Services;

    class EmployeeInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;
        public EmployeeInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //EmployeeInfo <employeeId> 
        public string Execute(params string[] args)
        {
            var id = int.Parse(args[0]);

            var employee = employeeService.ById(id);

            return
                $"ID: {id} - {employee.FirstName}" +
                $" {employee.LastName} -  ${employee.Salary:f2}";
        }
    }
}
