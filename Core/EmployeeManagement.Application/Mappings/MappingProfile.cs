using AutoMapper;
using EmployeeManagement.Application.Dtos.CompanyDtos;
using EmployeeManagement.Application.Dtos.DepartmentDtos;
using EmployeeManagement.Application.Dtos.EmployeeDtos;
using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Application.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company,ResultCompanyDto>().ForMember(dest => dest.CreatedDate, opt => opt
                                                 .MapFrom(src=>src.CreatedDate.ToString("dd-MM-yyyy HH:mm:ss")));
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<UpdateCompanyDto, Company>();

            CreateMap<Department, ResultDepartmentDto>().ForMember(dest => dest.CreatedDate, opt => opt
                                                        .MapFrom(src => src.CreatedDate.ToString("dd-MM-yyyy HH:mm:ss")))
                                                        .ForMember(dest => dest.CompanyName, opt => opt
                                                        .MapFrom(src => src.Company.Name));
            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<UpdateDepartmentDto, Department>();

            CreateMap<Employee, ResultEmployeeDto>().ForMember(dest => dest.CreatedDate, opt => opt
                                                    .MapFrom(src => src.CreatedDate.ToString("dd-MM-yyyy HH:mm:ss")))
                                                    .ForMember(dest => dest.BirthDate, opt => opt
                                                    .MapFrom(src => src.BirthDate.ToString("dd-MM-yyyy")))
                                                    .ForMember(dest => dest.CompanyName, opt => opt
                                                    .MapFrom(src => src.Department.Company.Name))
                                                    .ForMember(dest => dest.DepartmentName, opt => opt
                                                    .MapFrom(src => src.Department.Name));
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<UpdateEmployeeDto, Employee>();
        }
    }
}
