namespace Employees.App
{
    using AutoMapper;
    using Employees.Models;
    using DtoModels;
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, ManagerDto>();
            CreateMap<Employee, EmployeeManagerDto>()
                .ForMember(m => m.EmployeeFullName,
                           src => src.MapFrom(e => e.FullName))
                .ForMember(m => m.EmployeeSalary,
                            src => src.MapFrom(e => e.Salary))
                .ForMember(m => m.ManagerLastName,
                            src => src.MapFrom(e => e.Manager.LastName));
        }
    }
}
