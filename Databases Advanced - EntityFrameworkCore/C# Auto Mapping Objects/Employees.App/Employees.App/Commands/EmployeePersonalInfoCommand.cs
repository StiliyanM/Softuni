namespace Employees.App.Commands
{
    using System;
    using Employees.Services;

    class EmployeePersonalInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;
        public EmployeePersonalInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // employeeId
        public string Execute(params string[] args)
        {
            var id = int.Parse(args[0]);
            var employee = employeeService.PersonalById(id);

            return $"ID: 1 - {employee.FirstName} {employee.LastName}" +
                $" - ${employee.Salary:f2}" + Environment.NewLine +
                   $"Birthday: {employee.Birthday.Value.ToString("dd-MM-yyyy")}" + Environment.NewLine +
                   $"Address: {employee.Address}";


        }
    }
}
