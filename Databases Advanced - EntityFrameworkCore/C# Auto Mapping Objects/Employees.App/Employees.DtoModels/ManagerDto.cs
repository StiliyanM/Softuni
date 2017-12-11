using System.Collections.Generic;

namespace Employees.DtoModels
{
    public class ManagerDto
    {
        public int ManagerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<EmployeeDto> Employees { get; set; }

        public int EmployeeCount => Employees.Count;
    }
}
