
using AutoMapper;
using EmployeeManagement.Application.Dtos.CompanyDtos;
using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Application.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company,ResultCompanyDto>();
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<UpdateCompanyDto, Company>();
        }
    }
}
