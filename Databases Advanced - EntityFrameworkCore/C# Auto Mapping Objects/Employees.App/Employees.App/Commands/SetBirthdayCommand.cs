
namespace Employees.App.Commands
{
    using Employees.Services;
    using System;

    class SetBirthdayCommand : ICommand
    {
        private readonly EmployeeService employeeService;
        public SetBirthdayCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //SetBirthday <employeeId> <date
        public string Execute(params string[] args)
        {
            var id = int.Parse(args[0]);
            var date = DateTime.Parse(args[1]);

            employeeService.SetBirthday(id, date);

            return $"Employee {id} birthday set to {date}";
        }
    }
}
