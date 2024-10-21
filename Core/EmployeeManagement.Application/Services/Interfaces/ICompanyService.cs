using EmployeeManagement.Application.Dtos.CompanyDtos;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Helpers.Pagination;
using System.Linq.Expressions;

namespace EmployeeManagement.Application.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<Paginate<ResultCompanyDto>> GetAllAsync(int pageNumber,int pageSize);
        Task<Paginate<ResultCompanyDto>> GetWhereAsync(Expression<Func<Company, bool>> method, int pageNumber, int pageSize);
        Task<ResultCompanyDto> GetSingleAsync(Expression<Func<Company, bool>> method);
        Task<ResultCompanyDto> GetByIdAsync(int id);
        Task AddAsync(CreateCompanyDto model);
        Task<bool> RemoveAsync(int id);
        Task<bool> UpdateAsync(int id, UpdateCompanyDto model);
    }
}
