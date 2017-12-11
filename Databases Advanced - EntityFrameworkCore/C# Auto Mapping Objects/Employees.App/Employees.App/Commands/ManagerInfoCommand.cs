namespace Employees.App.Commands
{
    using Employees.Services;

    public class ManagerInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public ManagerInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //ManagerInfo <employeeId> 
        public string Execute(params string[] args)
        {
            var managerId = int.Parse(args[0]);

            string managerInfo = employeeService.GetManagerInfo(managerId);

            return managerInfo;
        }


    }
}
