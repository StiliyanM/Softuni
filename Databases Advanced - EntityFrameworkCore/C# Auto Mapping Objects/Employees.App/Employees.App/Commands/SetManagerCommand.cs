
namespace Employees.App.Commands
{
    using Employees.Services;

    public class SetManagerCommand : ICommand
    {
        private readonly EmployeeService employeeService;
        public SetManagerCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //SetManager <employeeId> <managerId> 
        public string Execute(params string[] args)
        {
            var employeeId = int.Parse(args[0]);
            var managerId = int.Parse(args[1]);

            employeeService.SetManager(employeeId, managerId);

            return $"{managerId} set as manager to {employeeId}";
        }
    }
}
