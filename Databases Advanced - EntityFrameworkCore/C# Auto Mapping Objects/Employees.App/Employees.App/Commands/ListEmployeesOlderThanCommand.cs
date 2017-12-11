
namespace Employees.App.Commands
{
    using Employees.Services;
    using System.Text;
    using System.Linq;

    class ListEmployeesOlderThanCommand : ICommand
    {
        private readonly EmployeeService employeeService;
        public ListEmployeesOlderThanCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //ListEmployeesOlderThan<age>
        public string Execute(params string[] args)
        {
            var age = int.Parse(args[0]);

            var employees = employeeService.GetEmployeesOlderThan(age);

            var result = new StringBuilder();

            foreach (var emp in employees.OrderByDescending(e => e.EmployeeSalary))
            {
                result.AppendLine($"{emp.EmployeeFullName}" +
                    $" - ${emp.EmployeeSalary} " +
                    $"- Manager: {emp.ManagerLastName ?? "[no manager]"}");
            }

            return result.ToString();
        }
    }
}
