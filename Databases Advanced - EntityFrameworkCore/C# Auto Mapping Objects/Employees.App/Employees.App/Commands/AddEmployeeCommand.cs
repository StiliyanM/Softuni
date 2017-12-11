namespace Employees.App.Commands
{
    using Employees.Services;
    using DtoModels;

    class AddEmployeeCommand : ICommand
    {
        private readonly EmployeeService employeeService;
        public AddEmployeeCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        //AddEmployee <firstName> <lastName> <salary> 
        public string Execute(params string[] args)
        {
            var firstName = args[0];
            var lastName = args[1];
            var salary = decimal.Parse(args[2]);

                var employeeDto = new EmployeeDto(firstName, lastName, salary);
                employeeService.AddEmployee(employeeDto);

            return "Employee added successfully";
        }
    }
}
