namespace Employees.Services
{
    using System;
    using Data;
    using Employees.DtoModels;
    using AutoMapper;
    using Employees.Models;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper.QueryableExtensions;

    public class EmployeeService
    {
        private readonly EmployeesContext context;

        public EmployeeService(EmployeesContext context)
        {
            this.context = context;
        }

        public EmployeeDto ById(int employeeId)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException($"There is no such employee");
            }

            var employeeDto = Mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        public List<EmployeeManagerDto> GetEmployeesOlderThan(int age)
        {
            var employees = context.Employees
                .Where(e => CalculateAge((DateTime)e.Birthday) > age)
                .ProjectTo<EmployeeManagerDto>()
                .ToList();

            return employees;
        }

        public static int CalculateAge(DateTime birthDay)
        {
            int years = DateTime.Now.Year - birthDay.Year;

            if ((birthDay.Month > DateTime.Now.Month) 
                || (birthDay.Month == DateTime.Now.Month 
                && birthDay.Day > DateTime.Now.Day))
                years--;

            return years;
        }

        public string GetManagerInfo(int managerId)
        {
            var employee = context.Employees.Find(managerId);

            var manager = Mapper.Map<ManagerDto>(employee);
            var managerInfo = new StringBuilder();

            managerInfo.AppendLine($"{manager.FirstName} {manager.LastName}" +
                $" | Employees: {manager.EmployeeCount}");

            foreach (var emp in manager.Employees)
            {
                managerInfo.AppendLine($"    - {emp.FirstName} {emp.LastName}" +
                    $" - ${emp.Salary:f2}");
            }

            return managerInfo.ToString();
        }

        public void SetManager(int employeeId, int managerId)
        {
            var employee = context.Employees.Find(employeeId);
            var manager = context.Employees.Find(managerId);

            employee.ManagerId = managerId;
            manager.Employees.Add(employee);

            context.SaveChanges();
        }

        public void AddEmployee(EmployeeDto dto)
        {
            var employee = Mapper.Map<Employee>(dto);

            context.Employees.Add(employee);

            context.SaveChanges();
        }

        public void SetBirthday(int employeeId,DateTime date)
        {
            var employee = context.Employees.Find(employeeId);

            employee.Birthday = date;

            context.SaveChanges();
        }

        public void SetAddress(int employeeId,string address)
        {
            var employee = context.Employees.Find(employeeId);

            employee.Address = address;

            context.SaveChanges();
        }

        public Employee PersonalById(int id)
        {
            var employee = context.Employees.Find(id);

            return employee;
        }


    }
}
