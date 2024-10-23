using EmployeeManagement.Application.Dtos.CompanyDtos;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Helpers.Pagination;
using System.Linq.Expressions;

namespace EmployeeManagement.Application.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<Paginate<ResultCompanyDto>> GetAllWithPaginationAsync(int pageNumber,int pageSize);
        Task<List<ResultCompanyDto>> GetAllAsync();
        Task<List<ResultCompanyDto>> GetWhereAsync(Expression<Func<Company, bool>> method);
        Task<ResultCompanyDto> GetSingleAsync(Expression<Func<Company, bool>> method);
        Task<ResultCompanyDto> GetByIdAsync(int id);
        Task AddAsync(CreateCompanyDto model);
        Task<bool> RemoveAsync(int id);
        Task<bool> UpdateAsync(int id, UpdateCompanyDto model);
    }
}
