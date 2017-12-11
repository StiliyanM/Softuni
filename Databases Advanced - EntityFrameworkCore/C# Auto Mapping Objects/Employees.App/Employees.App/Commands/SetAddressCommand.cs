
namespace Employees.App.Commands
{
    using Employees.Services;

    class SetAddressCommand : ICommand
    {
        private readonly EmployeeService employeeService;
        public SetAddressCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //SetBirthday <employeeId> <date
        public string Execute(params string[] args)
        {
            var id = int.Parse(args[0]);
            var address = args[1];

            employeeService.SetAddress(id, address);

            return $"Employee {id} address set to {address}";
        }
    }
}
